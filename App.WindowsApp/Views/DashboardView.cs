using App.Core.Contracts;
using App.Core.Utilities;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace App.WindowsApp.Views
{
    public partial class DashboardView : UserControl
    {
        private readonly IGymMemberService _memberService;
        private readonly ITrainerService _trainerService;
        private readonly IPaymentService _paymentService;
        private readonly IAttendanceService _attendanceService;
        private Chart chartPaymentStatus;
        private Chart chartMemberPlans;

        public DashboardView(IGymMemberService memberService, ITrainerService trainerService, IPaymentService paymentService, IAttendanceService attendanceService)
        {
            _memberService = memberService;
            _trainerService = trainerService;
            _paymentService = paymentService;
            _attendanceService = attendanceService;
            InitializeComponent();

        }

        private async void DashboardView_Load(object sender, EventArgs e)
        {
            InitCharts();
            await RefreshStatsAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await RefreshStatsAsync();
        }

        public async Task RefreshStatsAsync()
        {
            try
            {
                var allMembers = await _memberService.GetAllAsync();
                var allTrainers = await _trainerService.GetAllAsync();
                var allPayments = await _paymentService.GetAllAsync();
                var allAttendance = await _attendanceService.GetAllAsync();

                lblTotalMembers.Text = allMembers.Count.ToString();
                lblTotalTrainers.Text = allTrainers.Count.ToString();
                lblTotalPaid.Text = allPayments.Count(p => p.Status == PaymentStatusEnum.Paid).ToString();
                lblTotalPending.Text = allPayments.Count(p => p.Status == PaymentStatusEnum.Pending).ToString();
                lblTotalOverdue.Text = allPayments.Count(p => p.Status == PaymentStatusEnum.Overdue).ToString();
                lblActiveMembers.Text = allMembers.Count(m => m.Status == MemberStatusEnum.Active).ToString();
                lblTotalAttendance.Text = allAttendance.Count.ToString();
                await LoadChartsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void InitCharts()
        {

            chartPaymentStatus = new Chart();
            chartPaymentStatus.Size = new System.Drawing.Size(400, 300);
            chartPaymentStatus.Margin = new Padding(12);
            chartPaymentStatus.BackColor = System.Drawing.Color.White;


            chartMemberPlans = new Chart();
            chartMemberPlans.Size = new System.Drawing.Size(400, 300);
            chartMemberPlans.Margin = new Padding(12);
            chartMemberPlans.BackColor = System.Drawing.Color.White;

            flpCards.Controls.Add(chartPaymentStatus);
            flpCards.Controls.Add(chartMemberPlans);
        }

        private async Task LoadChartsAsync()
        {

            chartPaymentStatus.Series.Clear();
            chartPaymentStatus.ChartAreas.Clear();
            chartPaymentStatus.Titles.Clear();
            chartPaymentStatus.Legends.Clear();


            Title t1 = new Title("Payment Status");
            t1.Font = new System.Drawing.Font("Segoe UI", 11f,
                             System.Drawing.FontStyle.Bold);
            t1.Docking = Docking.Top;
            chartPaymentStatus.Titles.Add(t1);


            ChartArea area1 = new ChartArea("Area1");
            area1.BackColor = System.Drawing.Color.White;
            area1.BorderColor = System.Drawing.Color.Transparent;
            chartPaymentStatus.ChartAreas.Add(area1);


            Legend leg1 = new Legend("Leg1");
            leg1.Font = new System.Drawing.Font("Segoe UI", 9f);
            leg1.Docking = Docking.Bottom;
            leg1.Alignment = System.Drawing.StringAlignment.Center;
            leg1.BackColor = System.Drawing.Color.Transparent;
            chartPaymentStatus.Legends.Add(leg1);


            Series s1 = new Series("S1");
            s1.ChartType = SeriesChartType.Doughnut;
            s1.ChartArea = "Area1";
            s1.Legend = "Leg1";
            s1.IsVisibleInLegend = true;
            s1["DoughnutRadius"] = "60";
            s1["PieLabelStyle"] = "Disabled";
            s1.Font = new System.Drawing.Font("Segoe UI", 9f);


            var payments = await _paymentService.GetAllAsync();
            int paid = payments.Count(p => p.Status == PaymentStatusEnum.Paid);
            int pending = payments.Count(p => p.Status == PaymentStatusEnum.Pending);
            int overdue = payments.Count(p => p.Status == PaymentStatusEnum.Overdue);
            int total = paid + pending + overdue;

            int i0 = s1.Points.AddXY("Paid", paid);
            int i1 = s1.Points.AddXY("Pending", pending);
            int i2 = s1.Points.AddXY("Overdue", overdue);


            s1.Points[i0].Color = System.Drawing.Color.FromArgb(30, 30, 100);
            s1.Points[i1].Color = System.Drawing.Color.FromArgb(130, 130, 130);
            s1.Points[i2].Color = System.Drawing.Color.FromArgb(30, 30, 30);


            if (total > 0)
            {
                s1.Points[i0].LegendText =
                    $"Paid {(paid * 100 / total)}%";
                s1.Points[i1].LegendText =
                    $"Pending {(pending * 100 / total)}%";
                s1.Points[i2].LegendText =
                    $"Overdue {(overdue * 100 / total)}%";
            }

            chartPaymentStatus.Series.Add(s1);


            chartMemberPlans.Series.Clear();
            chartMemberPlans.ChartAreas.Clear();
            chartMemberPlans.Titles.Clear();
            chartMemberPlans.Legends.Clear();


            chartMemberPlans.Size = new System.Drawing.Size(550, 300);


            Title t2 = new Title("Members by Plan");
            t2.Font = new System.Drawing.Font("Segoe UI", 11f,
                             System.Drawing.FontStyle.Bold);
            t2.Docking = Docking.Top;
            chartMemberPlans.Titles.Add(t2);


            ChartArea area2 = new ChartArea("Area2");
            area2.BackColor = System.Drawing.Color.White;
            area2.BorderColor = System.Drawing.Color.Transparent;
            area2.AxisX.MajorGrid.Enabled = false;
            area2.AxisY.MajorGrid.LineColor =
                System.Drawing.Color.FromArgb(220, 220, 220);
            area2.AxisY.Minimum = 0;
            area2.AxisY.Interval = 1;
            area2.AxisX.LabelStyle.Font =
                new System.Drawing.Font("Segoe UI", 9f);
            area2.AxisY.LabelStyle.Font =
                new System.Drawing.Font("Segoe UI", 9f);
            chartMemberPlans.ChartAreas.Add(area2);


            var members = await _memberService.GetAllAsync();
            var grouped = members.GroupBy(m => m.Plan).ToList();

            System.Drawing.Color[] planColors =
            {
              System.Drawing.Color.FromArgb(30,  30,  100),
              System.Drawing.Color.FromArgb(130, 130, 130),
              System.Drawing.Color.FromArgb(30,  30,  30),
              System.Drawing.Color.FromArgb(100, 100, 160),
              System.Drawing.Color.FromArgb(80,  80,  80),
             };



            int xPosition = 1;
            foreach (var group in grouped)
            {
                Series s = new Series(group.Key.ToString());
                s.ChartType = SeriesChartType.Column;
                s.ChartArea = "Area2";
                s.IsVisibleInLegend = true;
                s.IsValueShownAsLabel = true;
                s.Font = new System.Drawing.Font(
                             "Segoe UI", 9f,
                             System.Drawing.FontStyle.Bold);
                s.LabelForeColor = System.Drawing.Color.Black;
                s["PointWidth"] = "0.8";
                s.Color = planColors[
                    (xPosition - 1) % planColors.Length];


                s.Points.AddXY(xPosition, group.Count());

                chartMemberPlans.Series.Add(s);
                xPosition++;
            }



            chartMemberPlans.ChartAreas["Area2"]
                .AxisX.Minimum = 0.5;
            chartMemberPlans.ChartAreas["Area2"]
                .AxisX.Maximum = xPosition - 0.5;
            chartMemberPlans.ChartAreas["Area2"]
                .AxisX.Interval = 1;


            chartMemberPlans.ChartAreas["Area2"]
                .AxisX.CustomLabels.Clear();

            int pos = 1;
            foreach (var group in grouped)
            {
                CustomLabel lbl = new CustomLabel();
                lbl.FromPosition = pos - 0.5;
                lbl.ToPosition = pos + 0.5;
                lbl.Text = group.Key.ToString();
                lbl.GridTicks = GridTickTypes.None;
                chartMemberPlans.ChartAreas["Area2"]
                    .AxisX.CustomLabels.Add(lbl);
                pos++;
            }
        }
    }

}