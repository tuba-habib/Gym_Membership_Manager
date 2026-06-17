using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;

namespace App.WindowsApp.Forms
{
    public partial class GymMemberForm : Form
    {
        private GymMemberFormModeEnum _mode;
        private GymMember _member;
        private IGymMemberService _service;

        public GymMemberForm(GymMemberFormModeEnum mode, GymMember? member, IGymMemberService service)
        {
            InitializeComponent();

            cmbPlan.Items.Clear();
            cmbPlan.DataSource = Enum.GetValues(typeof(MembershipPlanEnum));
            cmbPlan.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.DataSource = Enum.GetValues(typeof(MemberStatusEnum));
            cmbStatus.SelectedIndex = 0;

            _mode = mode;
            _member = member;
            _service = service;

            if (mode == GymMemberFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
                this.Text = "Edit Member";
            }
            else if (mode == GymMemberFormModeEnum.View)
            {
                btnSave.Visible = false;
                this.Text = "View Member";
            }
            else
            {
                this.Text = "Add Member";
                lblId.Visible = false;
                txtId.Visible = false;
            }

            if (mode == GymMemberFormModeEnum.Edit || mode == GymMemberFormModeEnum.View)
            {
                txtId.Text = member.Id;
                txtName.Text = member.Name;
                txtPhone.Text = member.Phone;
                txtEmail.Text = member.Email;
                txtAddress.Text = member.Address;
                cmbPlan.SelectedItem = member.Plan;
                cmbStatus.SelectedItem = member.Status;
                dtpJoinDate.Value = member.JoinDate;
            }

            if (mode == GymMemberFormModeEnum.View)
            {
                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtAddress.ReadOnly = true;
                cmbPlan.Enabled = false;
                cmbStatus.Enabled = false;
                dtpJoinDate.Enabled = false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be empty", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_mode == GymMemberFormModeEnum.Add)
                {
                    GymMember newMember = new GymMember();
                    newMember.Name = txtName.Text;
                    newMember.Phone = txtPhone.Text;
                    newMember.Email = txtEmail.Text;
                    newMember.Address = txtAddress.Text;
                    newMember.Plan = (MembershipPlanEnum)cmbPlan.SelectedItem;
                    newMember.Status = (MemberStatusEnum)cmbStatus.SelectedItem;
                    newMember.JoinDate = dtpJoinDate.Value;

                    GymMember temp = await _service.AddAsync(newMember);
                    txtId.Text = temp?.Id ?? "";
                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == GymMemberFormModeEnum.Edit)
                {
                    _member.Name = txtName.Text;
                    _member.Phone = txtPhone.Text;
                    _member.Email = txtEmail.Text;
                    _member.Address = txtAddress.Text;
                    _member.Plan = (MembershipPlanEnum)cmbPlan.SelectedItem;
                    _member.Status = (MemberStatusEnum)cmbStatus.SelectedItem;
                    _member.JoinDate = dtpJoinDate.Value;

                    await _service.UpdateAsync(_member);
                    MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}