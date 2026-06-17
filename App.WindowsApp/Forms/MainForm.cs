using App.Core.Contracts;
using App.Core.Services;
using App.WindowsApp.Views;
using System.Configuration;

namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly string _connStr;
        private readonly IGymMemberService _memberService;
        private readonly ITrainerService _trainerService;
        private readonly IPaymentService _paymentService;
        private readonly IAttendanceService _attendanceService;
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();
            _connStr = ConfigurationManager.ConnectionStrings["GymDB"].ConnectionString;
            _memberService = new DBGymMemberService(_connStr);
            _trainerService = new DBTrainerService(_connStr);
            _paymentService = new DBPaymentService(_connStr);
            _attendanceService = new DBAttendanceService(_connStr);

            Load += MainForm_Load;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await UpdateStatusCountsAsync();
        }

        private async Task UpdateStatusCountsAsync()
        {
            try
            {
                int memberCount = (await _memberService.GetAllAsync()).Count;
                int trainerCount = (await _trainerService.GetAllAsync()).Count;
                tsLabelStatus.Text = $"Members: {memberCount}    |    Trainers: {trainerCount}";
            }
            catch
            {
                tsLabelStatus.Text = "Status unavailable";
            }
        }

        private async void btnDashboard_Click(object sender, EventArgs e)
        {
            await ShowViewAsync(() => new DashboardView(_memberService, _trainerService, _paymentService, _attendanceService));
        }

        private async void btnMembers_Click(object sender, EventArgs e)
        {
            await ShowViewAsync(() => new GymMembersView(_memberService));
        }

        private async void btnTrainers_Click(object sender, EventArgs e)
        {
            await ShowViewAsync(() => new TrainersView(_trainerService));
        }

        private async void btnPayments_Click(object sender, EventArgs e)
        {
            await ShowViewAsync(() => new PaymentsView(_paymentService, _memberService, _trainerService));
        }

        private async void btnAttendance_Click(object sender, EventArgs e)
        {
            await ShowViewAsync(() => new AttendanceView(_attendanceService, _memberService));
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void flpLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task ShowViewAsync<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            bool isNew = false;

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
                isNew = true;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();

            await UpdateStatusCountsAsync();

            if (!isNew && view is DashboardView dashboard)
                await dashboard.RefreshStatsAsync();
        }
    }
}