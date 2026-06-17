using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;

namespace App.WindowsApp.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly IPaymentService _paymentService;
        private readonly IGymMemberService _memberService;
        private readonly ITrainerService _trainerService;
        private MembershipPayment _payment;
        private bool _isEdit;

        public PaymentForm(IPaymentService paymentService, IGymMemberService memberService, ITrainerService trainerService, MembershipPayment? payment = null)
        {
            InitializeComponent();
            _paymentService = paymentService;
            _memberService = memberService;
            _trainerService = trainerService;

            cmbStatus.Items.Clear();
            cmbStatus.DataSource = Enum.GetValues(typeof(PaymentStatusEnum));
            cmbStatus.SelectedIndex = 0;

            if (payment != null)
            {
                _payment = payment;
                _isEdit = true;
                this.Text = "Edit Payment Record";
                btnSave.Text = "Update";

                txtMemberId.Text = payment.MemberId;
                txtMemberName.Text = payment.MemberName;
                txtTrainerId.Text = payment.TrainerId;
                txtTrainerName.Text = payment.TrainerName;
                if (payment.DueDate.HasValue) dtpDueDate.Value = payment.DueDate.Value;
                if (payment.PaymentDate.HasValue) dtpPaymentDate.Value = payment.PaymentDate.Value;
                cmbStatus.SelectedItem = payment.Status;

                dtpPaymentDate.Visible = payment.Status == PaymentStatusEnum.Paid;
                lblPaymentDate.Visible = payment.Status == PaymentStatusEnum.Paid;

                btnPickMember.Enabled = false;
                btnPickTrainer.Enabled = false;
            }
            else
            {
                _payment = new MembershipPayment();
                _isEdit = false;
                this.Text = "Add Payment";

                dtpPaymentDate.Visible = false;
                lblPaymentDate.Visible = false;
            }
        }

        private void btnPickMember_Click(object sender, EventArgs e)
        {
            using var picker = new MemberPicker(_memberService);
            if (picker.ShowDialog() == DialogResult.OK && picker.SelectedMember != null)
            {
                txtMemberId.Text = picker.SelectedMember.Id;
                txtMemberName.Text = picker.SelectedMember.Name;
            }
        }

        private void btnPickTrainer_Click(object sender, EventArgs e)
        {
            using var picker = new TrainerPicker(_trainerService);
            if (picker.ShowDialog() == DialogResult.OK && picker.SelectedTrainer != null)
            {
                txtTrainerId.Text = picker.SelectedTrainer.Id;
                txtTrainerName.Text = picker.SelectedTrainer.Name;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberId.Text))
            {
                MessageBox.Show("Please select a member.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _payment.MemberId = txtMemberId.Text;
                _payment.MemberName = txtMemberName.Text;
                _payment.TrainerId = txtTrainerId.Text;
                _payment.TrainerName = txtTrainerName.Text;
                _payment.DueDate = dtpDueDate.Value;
                _payment.Status = (PaymentStatusEnum)cmbStatus.SelectedItem;

                if (_payment.Status == PaymentStatusEnum.Paid)
                    _payment.PaymentDate = DateTime.Now;
                else
                    _payment.PaymentDate = null;

                if (_isEdit)
                {
                    await _paymentService.UpdateAsync(_payment);
                    MessageBox.Show("Payment record updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _paymentService.AddAsync(_payment);
                    MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}