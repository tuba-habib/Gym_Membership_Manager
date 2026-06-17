using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;

namespace App.WindowsApp.Views
{
    public partial class PaymentsView : UserControl
    {
        private readonly IPaymentService _paymentService;
        private readonly IGymMemberService _memberService;
        private readonly ITrainerService _trainerService;
        private BindingSource _bindingSource = new BindingSource();
        private bool _isLoaded = false;

        public PaymentsView(IPaymentService paymentService, IGymMemberService memberService, ITrainerService trainerService)
        {
            _paymentService = paymentService;
            _memberService = memberService;
            _trainerService = trainerService;
            InitializeComponent();
            dgvPayments.DataSource = _bindingSource;

            cmbStatusFilter.Items.Clear();
            var statuses = new List<object> { "--ALL--" };
            statuses.AddRange(Enum.GetValues(typeof(PaymentStatusEnum)).Cast<object>());
            cmbStatusFilter.DataSource = statuses;
            cmbStatusFilter.SelectedIndex = 0;

            this.Load += PaymentsView_Load;
        }

        private async void PaymentsView_Load(object sender, EventArgs e)
        {
            _isLoaded = true;
            await LoadPaymentsAsync();
        }

        private async Task LoadPaymentsAsync()
        {
            _bindingSource.DataSource = await _paymentService.GetAllAsync();
        }

        private async void tsbAddPayment_Click(object sender, EventArgs e)
        {
            var form = new PaymentForm(_paymentService, _memberService, _trainerService);
            if (form.ShowDialog() == DialogResult.OK) await LoadPaymentsAsync();
        }

        private async void tsbMarkPaid_Click(object sender, EventArgs e)
        {
            MembershipPayment selected = _bindingSource.Current as MembershipPayment;
            if (selected == null)
            {
                MessageBox.Show("Please select a payment record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selected.Status == PaymentStatusEnum.Paid)
            {
                MessageBox.Show("This payment is already marked as Paid.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirm = MessageBox.Show($"Mark payment for \"{selected.MemberName}\" as Paid?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                selected.Status = PaymentStatusEnum.Paid;
                selected.PaymentDate = DateTime.Now;
                await _paymentService.UpdateAsync(selected);
                MessageBox.Show("Payment marked as Paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadPaymentsAsync();
            }
        }

        private async void tsbEdit_Click(object sender, EventArgs e)
        {
            MembershipPayment selected = _bindingSource.Current as MembershipPayment;
            if (selected != null)
            {
                var form = new PaymentForm(_paymentService, _memberService, _trainerService, selected);
                if (form.ShowDialog() == DialogResult.OK) await LoadPaymentsAsync();
            }
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            MembershipPayment selected = _bindingSource.Current as MembershipPayment;
            if (selected != null)
            {
                var confirm = MessageBox.Show("Delete this payment record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    await _paymentService.DeleteAsync(selected.Id);
                    await LoadPaymentsAsync();
                }
            }
        }

        private async void tsbRefresh_Click(object sender, EventArgs e) => await LoadPaymentsAsync();

        private async void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isLoaded) return;

            if (cmbStatusFilter.SelectedItem == null || cmbStatusFilter.SelectedItem.ToString() == "--ALL--")
                await LoadPaymentsAsync();
            else
                _bindingSource.DataSource = await _paymentService.GetByStatusAsync((PaymentStatusEnum)cmbStatusFilter.SelectedItem);
        }
    }
}