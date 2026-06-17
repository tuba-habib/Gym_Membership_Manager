using App.Core.Contracts;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class AttendanceForm : Form
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IGymMemberService _memberService;
        private readonly AttendanceFormModeEnum _mode;
        private readonly Attendance _attendance;

        public AttendanceForm(IAttendanceService attendanceService, IGymMemberService memberService, AttendanceFormModeEnum mode, Attendance? attendance = null)
        {
            InitializeComponent();
            _attendanceService = attendanceService;
            _memberService = memberService;
            _mode = mode;
            _attendance = attendance ?? new Attendance();
            SetupMode();
            this.Load += AttendanceForm_Load;
        }

        private async void AttendanceForm_Load(object sender, EventArgs e)
        {
            await PopulateFieldsAsync();
        }

        private async Task PopulateFieldsAsync()
        {
            txtMemberName.Text = await GetMemberNameAsync();
            dtpDate.Value = _attendance.CheckInDate == default ? DateTime.Now : _attendance.CheckInDate;
            dtpTime.Value = DateTime.Today.Add(_attendance.CheckInTime == default ? DateTime.Now.TimeOfDay : _attendance.CheckInTime);
            txtNotes.Text = _attendance.Notes;
        }

        private async Task<string> GetMemberNameAsync()
        {
            if (string.IsNullOrWhiteSpace(_attendance.MemberId))
                return _attendance.MemberName ?? string.Empty;

            var member = await _memberService.GetByIdAsync(_attendance.MemberId);
            if (member == null)
                return _attendance.MemberName ?? string.Empty;

            _attendance.MemberName = member.Name ?? string.Empty;
            return _attendance.MemberName;
        }

        private void SetupMode()
        {
            switch (_mode)
            {
                case AttendanceFormModeEnum.Add:
                    this.Text = "Add Attendance";
                    break;
                case AttendanceFormModeEnum.Edit:
                    this.Text = "Edit Attendance";
                    btnSave.Text = "Update";
                    break;
                case AttendanceFormModeEnum.View:
                    this.Text = "View Attendance";
                    btnPickMember.Enabled = false;
                    dtpDate.Enabled = false;
                    dtpTime.Enabled = false;
                    txtNotes.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
        }

        private void btnPickMember_Click(object sender, EventArgs e)
        {
            using var picker = new MemberPicker(_memberService);
            if (picker.ShowDialog() == DialogResult.OK && picker.SelectedMember != null)
            {
                _attendance.MemberId = picker.SelectedMember.Id;
                _attendance.MemberName = picker.SelectedMember.Name;
                txtMemberName.Text = _attendance.MemberName;
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(_attendance.MemberId))
            {
                MessageBox.Show("Please select a member.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMemberName.Text))
            {
                MessageBox.Show("Member Name cannot be empty", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    _attendance.MemberName = txtMemberName.Text;
                    _attendance.CheckInDate = dtpDate.Value.Date;
                    _attendance.CheckInTime = dtpTime.Value.TimeOfDay;
                    _attendance.Notes = txtNotes.Text;

                    if (_mode == AttendanceFormModeEnum.Add)
                    {
                        await _attendanceService.AddAsync(_attendance);
                        MessageBox.Show("Attendance recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        await _attendanceService.UpdateAsync(_attendance);
                        MessageBox.Show("Attendance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}