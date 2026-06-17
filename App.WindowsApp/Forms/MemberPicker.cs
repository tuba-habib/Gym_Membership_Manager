using App.Core.Contracts;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class MemberPicker : Form
    {
        private readonly IGymMemberService _memberService;
        private BindingSource _bindingSource;
        public GymMember SelectedMember { get; private set; }

        public MemberPicker(IGymMemberService service)
        {
            InitializeComponent();
            _memberService = service;
            _bindingSource = new BindingSource();
            lsMembers.DataSource = _bindingSource;
            this.Load += MemberPicker_Load;
        }

        private async void MemberPicker_Load(object sender, EventArgs e)
        {
            await LoadMembersAsync(string.Empty);
        }

        private async Task LoadMembersAsync(string query)
        {
            var members = string.IsNullOrWhiteSpace(query)
                ? await _memberService.GetAllAsync()
                : await _memberService.SearchAsync(query, null, null);
            _bindingSource.DataSource = members;
            lsMembers.DisplayMember = "Name";
            lsMembers.ValueMember = "Id";
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadMembersAsync(txtSearch.Text);
        }

        private void SelectMember()
        {
            if (lsMembers.SelectedItem != null && lsMembers.SelectedItem is GymMember)
            {
                SelectedMember = (GymMember)lsMembers.SelectedItem;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a member", "Member Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) => SelectMember();
        private void lsMembers_DoubleClick(object sender, EventArgs e) => SelectMember();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}