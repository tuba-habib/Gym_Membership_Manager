using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;

namespace App.WindowsApp.Views
{
    public partial class GymMembersView : UserControl
    {
        private readonly IGymMemberService _memberService;
        private BindingSource _bindingSource = new BindingSource();
        private bool _isLoaded = false;

        public GymMembersView(IGymMemberService service)
        {
            _memberService = service;
            InitializeComponent();
            dgvMembers.DataSource = _bindingSource;
        }

        private async void GymMembersView_Load(object sender, EventArgs e)
        {
            cmbPlan.Items.Clear();
            var plans = new List<object> { "--ALL--" };
            plans.AddRange(Enum.GetValues(typeof(MembershipPlanEnum)).Cast<object>());
            cmbPlan.DataSource = plans;
            cmbPlan.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            var statuses = new List<object> { "--ALL--" };
            statuses.AddRange(Enum.GetValues(typeof(MemberStatusEnum)).Cast<object>());
            cmbStatus.DataSource = statuses;
            cmbStatus.SelectedIndex = 0;

            _isLoaded = true;
            await LoadMembersAsync();
        }

        private async Task LoadMembersAsync()
        {
            _bindingSource.DataSource = await _memberService.GetAllAsync();
        }

        private async Task RefreshGridAsync()
        {
            if (!_isLoaded) return;

            string searchText = txtSearch.Text ?? "";

            MembershipPlanEnum? selectedPlan = null;
            if (cmbPlan.SelectedItem != null && cmbPlan.SelectedItem is MembershipPlanEnum)
                selectedPlan = (MembershipPlanEnum)cmbPlan.SelectedItem;

            MemberStatusEnum? selectedStatus = null;
            if (cmbStatus.SelectedItem != null && cmbStatus.SelectedItem is MemberStatusEnum)
                selectedStatus = (MemberStatusEnum)cmbStatus.SelectedItem;

            _bindingSource.DataSource = await _memberService.SearchAsync(searchText, selectedPlan, selectedStatus);
        }

        private async void tsbAdd_Click(object sender, EventArgs e)
        {
            var form = new GymMemberForm(GymMemberFormModeEnum.Add, null, _memberService);
            if (form.ShowDialog() == DialogResult.OK) await RefreshGridAsync();
        }

        private async void tsbEdit_Click(object sender, EventArgs e)
        {
            GymMember selected = _bindingSource.Current as GymMember;
            if (selected != null)
            {
                var form = new GymMemberForm(GymMemberFormModeEnum.Edit, selected, _memberService);
                if (form.ShowDialog() == DialogResult.OK) await RefreshGridAsync();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            GymMember selected = _bindingSource.Current as GymMember;
            if (selected != null)
            {
                var form = new GymMemberForm(GymMemberFormModeEnum.View, selected, _memberService);
                form.ShowDialog();
            }
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            GymMember selected = _bindingSource.Current as GymMember;
            if (selected != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    await _memberService.DeleteAsync(selected.Id);
                    await RefreshGridAsync();
                }
            }
        }

        private async void tsbRefresh_Click(object sender, EventArgs e) => await LoadMembersAsync();
        private async void txtSearch_TextChanged(object sender, EventArgs e) => await RefreshGridAsync();
        private async void cmbPlan_SelectedIndexChanged(object sender, EventArgs e) => await RefreshGridAsync();
        private async void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => await RefreshGridAsync();
    }
}