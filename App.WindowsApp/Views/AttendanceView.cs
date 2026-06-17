using App.Core.Contracts;
using App.Core.Models;
using App.WindowsApp.Forms;
using System.Collections.Generic;
using System.Linq;

namespace App.WindowsApp.Views
{
    public partial class AttendanceView : UserControl
    {
        private readonly IAttendanceService _attendanceService;
        private readonly IGymMemberService _memberService;
        private List<Attendance> _allAttendance = new List<Attendance>();

        public AttendanceView(IAttendanceService attendanceService, IGymMemberService memberService)
        {
            InitializeComponent();
            _attendanceService = attendanceService;
            _memberService = memberService;
        }

        private async void AttendanceView_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }


        private async Task LoadDataAsync()
        {
            dgvAttendance.AutoGenerateColumns = false;
            _allAttendance = await _attendanceService.GetAllAsync();
            ShowInGrid(_allAttendance);
        }


        private void ShowInGrid(List<Attendance> list)
        {
            var display = list.Select(a => new
            {
                Id = a.Id,
                MemberId = a.MemberId,
                MemberName = a.MemberName,
                CheckInDate = a.CheckInDate
                                  .ToString("MM/dd/yyyy"),
                CheckInTime = DateTime.Today
                                  .Add(a.CheckInTime)
                                  .ToString("hh:mm:ss tt"),
                Notes = a.Notes
            }).ToList();

            dgvAttendance.DataSource = null;
            dgvAttendance.DataSource = display;
        }


        private Attendance? GetSelectedAttendance()
        {
            if (dgvAttendance.CurrentRow == null)
                return null;

            var value = dgvAttendance.CurrentRow.Cells[0].Value;

            if (value == null)
                return null;

            string id = value.ToString() ?? string.Empty;

            return _allAttendance.FirstOrDefault(a => a.Id == id);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AttendanceForm(
                _attendanceService,
                _memberService,
                AttendanceFormModeEnum.Add);

            if (form.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }


        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var attendance = GetSelectedAttendance();

            if (attendance == null)
            {
                MessageBox.Show(
                    "Please select a record to edit.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var form = new AttendanceForm(
                _attendanceService,
                _memberService,
                AttendanceFormModeEnum.Edit,
                attendance);

            if (form.ShowDialog() == DialogResult.OK)
                await LoadDataAsync();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            var attendance = GetSelectedAttendance();

            if (attendance == null)
            {
                MessageBox.Show(
                    "Please select a record to view.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var form = new AttendanceForm(
                _attendanceService,
                _memberService,
                AttendanceFormModeEnum.View,
                attendance);

            form.ShowDialog();
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var attendance = GetSelectedAttendance();

            if (attendance == null)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    await _attendanceService.DeleteAsync(attendance.Id);
                    MessageBox.Show(
                        "Record deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await LoadDataAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error deleting: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                ShowInGrid(_allAttendance);
                return;
            }

            var filtered = _allAttendance.Where(a =>
                (a.MemberId != null &&
                 a.MemberId.ToLower().Contains(query)) ||
                (a.MemberName != null &&
                 a.MemberName.ToLower().Contains(query)) ||
                (a.Notes != null &&
                 a.Notes.ToLower().Contains(query)) ||
                a.CheckInDate.ToString("MM/dd/yyyy")
                             .Contains(query)
            ).ToList();

            ShowInGrid(filtered);
        }
    }
}