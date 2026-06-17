namespace App.WindowsApp.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tblDashboard = new TableLayoutPanel();
            pnlTopBar = new Panel();
            lblWelcome = new Label();
            btnRefresh = new Button();
            pnlCards = new Panel();
            flpCards = new FlowLayoutPanel();
            pnlMembers = new Panel();
            lblMembersLabel = new Label();
            lblTotalMembers = new Label();
            pnlTrainers = new Panel();
            lblTrainersLabel = new Label();
            lblTotalTrainers = new Label();
            pnlPaid = new Panel();
            lblPaidLabel = new Label();
            lblTotalPaid = new Label();
            pnlPending = new Panel();
            lblPendingLabel = new Label();
            lblTotalPending = new Label();
            pnlOverdue = new Panel();
            lblOverdueLabel = new Label();
            lblTotalOverdue = new Label();
            pnlActive = new Panel();
            lblActiveLabel = new Label();
            lblActiveMembers = new Label();
            panel1 = new Panel();
            lblAttendanceLabel = new Label();
            lblTotalAttendance = new Label();
            tblDashboard.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlCards.SuspendLayout();
            flpCards.SuspendLayout();
            pnlMembers.SuspendLayout();
            pnlTrainers.SuspendLayout();
            pnlPaid.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlOverdue.SuspendLayout();
            pnlActive.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(pnlTopBar, 0, 0);
            tblDashboard.Controls.Add(pnlCards, 0, 1);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 2;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDashboard.Size = new Size(1663, 683);
            tblDashboard.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(lblWelcome);
            pnlTopBar.Controls.Add(btnRefresh);
            pnlTopBar.Dock = DockStyle.Fill;
            pnlTopBar.Location = new Point(3, 3);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1657, 69);
            pnlTopBar.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(30, 30, 30);
            lblWelcome.Location = new Point(25, 15);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(184, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Dashboard";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Image = Properties.Resources.ico_Refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1513, 15);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(125, 40);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(flpCards);
            pnlCards.Dock = DockStyle.Fill;
            pnlCards.Location = new Point(3, 78);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(1657, 602);
            pnlCards.TabIndex = 1;
            // 
            // flpCards
            // 
            flpCards.AutoScroll = true;
            flpCards.Controls.Add(pnlMembers);
            flpCards.Controls.Add(pnlTrainers);
            flpCards.Controls.Add(pnlPaid);
            flpCards.Controls.Add(pnlPending);
            flpCards.Controls.Add(pnlOverdue);
            flpCards.Controls.Add(pnlActive);
            flpCards.Controls.Add(panel1);
            flpCards.Dock = DockStyle.Fill;
            flpCards.Location = new Point(0, 0);
            flpCards.Margin = new Padding(4);
            flpCards.Name = "flpCards";
            flpCards.Size = new Size(1657, 602);
            flpCards.TabIndex = 0;
            // 
            // pnlMembers
            // 
            pnlMembers.BackColor = Color.White;
            pnlMembers.BorderStyle = BorderStyle.FixedSingle;
            pnlMembers.Controls.Add(lblMembersLabel);
            pnlMembers.Controls.Add(lblTotalMembers);
            pnlMembers.Location = new Point(12, 12);
            pnlMembers.Margin = new Padding(12);
            pnlMembers.Name = "pnlMembers";
            pnlMembers.Padding = new Padding(19);
            pnlMembers.Size = new Size(199, 150);
            pnlMembers.TabIndex = 0;
            // 
            // lblMembersLabel
            // 
            lblMembersLabel.AutoSize = true;
            lblMembersLabel.Font = new Font("Segoe UI", 10F);
            lblMembersLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblMembersLabel.Location = new Point(38, 38);
            lblMembersLabel.Margin = new Padding(4, 0, 4, 0);
            lblMembersLabel.Name = "lblMembersLabel";
            lblMembersLabel.Size = new Size(141, 28);
            lblMembersLabel.TabIndex = 0;
            lblMembersLabel.Text = "Total Members";
            // 
            // lblTotalMembers
            // 
            lblTotalMembers.AutoSize = true;
            lblTotalMembers.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalMembers.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalMembers.Location = new Point(38, 81);
            lblTotalMembers.Margin = new Padding(4, 0, 4, 0);
            lblTotalMembers.Name = "lblTotalMembers";
            lblTotalMembers.Size = new Size(64, 74);
            lblTotalMembers.TabIndex = 1;
            lblTotalMembers.Text = "0";
            // 
            // pnlTrainers
            // 
            pnlTrainers.BackColor = Color.White;
            pnlTrainers.BorderStyle = BorderStyle.FixedSingle;
            pnlTrainers.Controls.Add(lblTrainersLabel);
            pnlTrainers.Controls.Add(lblTotalTrainers);
            pnlTrainers.Location = new Point(235, 12);
            pnlTrainers.Margin = new Padding(12);
            pnlTrainers.Name = "pnlTrainers";
            pnlTrainers.Padding = new Padding(19);
            pnlTrainers.Size = new Size(197, 150);
            pnlTrainers.TabIndex = 1;
            // 
            // lblTrainersLabel
            // 
            lblTrainersLabel.AutoSize = true;
            lblTrainersLabel.Font = new Font("Segoe UI", 10F);
            lblTrainersLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblTrainersLabel.Location = new Point(38, 38);
            lblTrainersLabel.Margin = new Padding(4, 0, 4, 0);
            lblTrainersLabel.Name = "lblTrainersLabel";
            lblTrainersLabel.Size = new Size(125, 28);
            lblTrainersLabel.TabIndex = 0;
            lblTrainersLabel.Text = "Total Trainers";
            // 
            // lblTotalTrainers
            // 
            lblTotalTrainers.AutoSize = true;
            lblTotalTrainers.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalTrainers.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalTrainers.Location = new Point(38, 81);
            lblTotalTrainers.Margin = new Padding(4, 0, 4, 0);
            lblTotalTrainers.Name = "lblTotalTrainers";
            lblTotalTrainers.Size = new Size(64, 74);
            lblTotalTrainers.TabIndex = 1;
            lblTotalTrainers.Text = "0";
            // 
            // pnlPaid
            // 
            pnlPaid.BackColor = Color.White;
            pnlPaid.BorderStyle = BorderStyle.FixedSingle;
            pnlPaid.Controls.Add(lblPaidLabel);
            pnlPaid.Controls.Add(lblTotalPaid);
            pnlPaid.Location = new Point(456, 12);
            pnlPaid.Margin = new Padding(12);
            pnlPaid.Name = "pnlPaid";
            pnlPaid.Padding = new Padding(19);
            pnlPaid.Size = new Size(187, 150);
            pnlPaid.TabIndex = 2;
            // 
            // lblPaidLabel
            // 
            lblPaidLabel.AutoSize = true;
            lblPaidLabel.Font = new Font("Segoe UI", 10F);
            lblPaidLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblPaidLabel.Location = new Point(38, 38);
            lblPaidLabel.Margin = new Padding(4, 0, 4, 0);
            lblPaidLabel.Name = "lblPaidLabel";
            lblPaidLabel.Size = new Size(137, 28);
            lblPaidLabel.TabIndex = 0;
            lblPaidLabel.Text = "Payments Paid";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalPaid.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalPaid.Location = new Point(38, 81);
            lblTotalPaid.Margin = new Padding(4, 0, 4, 0);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(64, 74);
            lblTotalPaid.TabIndex = 1;
            lblTotalPaid.Text = "0";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.FromArgb(245, 245, 245);
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(lblPendingLabel);
            pnlPending.Controls.Add(lblTotalPending);
            pnlPending.Location = new Point(667, 12);
            pnlPending.Margin = new Padding(12);
            pnlPending.Name = "pnlPending";
            pnlPending.Padding = new Padding(19);
            pnlPending.Size = new Size(212, 150);
            pnlPending.TabIndex = 3;
            // 
            // lblPendingLabel
            // 
            lblPendingLabel.AutoSize = true;
            lblPendingLabel.Font = new Font("Segoe UI", 10F);
            lblPendingLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblPendingLabel.Location = new Point(38, 38);
            lblPendingLabel.Margin = new Padding(4, 0, 4, 0);
            lblPendingLabel.Name = "lblPendingLabel";
            lblPendingLabel.Size = new Size(171, 28);
            lblPendingLabel.TabIndex = 0;
            lblPendingLabel.Text = "Payments Pending";
            // 
            // lblTotalPending
            // 
            lblTotalPending.AutoSize = true;
            lblTotalPending.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalPending.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalPending.Location = new Point(38, 81);
            lblTotalPending.Margin = new Padding(4, 0, 4, 0);
            lblTotalPending.Name = "lblTotalPending";
            lblTotalPending.Size = new Size(64, 74);
            lblTotalPending.TabIndex = 1;
            lblTotalPending.Text = "0";
            // 
            // pnlOverdue
            // 
            pnlOverdue.BackColor = Color.FromArgb(240, 240, 240);
            pnlOverdue.BorderStyle = BorderStyle.FixedSingle;
            pnlOverdue.Controls.Add(lblOverdueLabel);
            pnlOverdue.Controls.Add(lblTotalOverdue);
            pnlOverdue.Location = new Point(903, 12);
            pnlOverdue.Margin = new Padding(12);
            pnlOverdue.Name = "pnlOverdue";
            pnlOverdue.Padding = new Padding(19);
            pnlOverdue.Size = new Size(177, 150);
            pnlOverdue.TabIndex = 4;
            // 
            // lblOverdueLabel
            // 
            lblOverdueLabel.AutoSize = true;
            lblOverdueLabel.Font = new Font("Segoe UI", 10F);
            lblOverdueLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblOverdueLabel.Location = new Point(38, 38);
            lblOverdueLabel.Margin = new Padding(4, 0, 4, 0);
            lblOverdueLabel.Name = "lblOverdueLabel";
            lblOverdueLabel.Size = new Size(87, 28);
            lblOverdueLabel.TabIndex = 0;
            lblOverdueLabel.Text = "Overdue";
            // 
            // lblTotalOverdue
            // 
            lblTotalOverdue.AutoSize = true;
            lblTotalOverdue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalOverdue.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalOverdue.Location = new Point(38, 81);
            lblTotalOverdue.Margin = new Padding(4, 0, 4, 0);
            lblTotalOverdue.Name = "lblTotalOverdue";
            lblTotalOverdue.Size = new Size(64, 74);
            lblTotalOverdue.TabIndex = 1;
            lblTotalOverdue.Text = "0";
            // 
            // pnlActive
            // 
            pnlActive.BackColor = Color.White;
            pnlActive.BorderStyle = BorderStyle.FixedSingle;
            pnlActive.Controls.Add(lblActiveLabel);
            pnlActive.Controls.Add(lblActiveMembers);
            pnlActive.Location = new Point(1104, 12);
            pnlActive.Margin = new Padding(12);
            pnlActive.Name = "pnlActive";
            pnlActive.Padding = new Padding(19);
            pnlActive.Size = new Size(209, 150);
            pnlActive.TabIndex = 5;
            // 
            // lblActiveLabel
            // 
            lblActiveLabel.AutoSize = true;
            lblActiveLabel.Font = new Font("Segoe UI", 10F);
            lblActiveLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblActiveLabel.Location = new Point(38, 38);
            lblActiveLabel.Margin = new Padding(4, 0, 4, 0);
            lblActiveLabel.Name = "lblActiveLabel";
            lblActiveLabel.Size = new Size(153, 28);
            lblActiveLabel.TabIndex = 0;
            lblActiveLabel.Text = "Active Members";
            // 
            // lblActiveMembers
            // 
            lblActiveMembers.AutoSize = true;
            lblActiveMembers.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblActiveMembers.ForeColor = Color.FromArgb(30, 30, 30);
            lblActiveMembers.Location = new Point(38, 81);
            lblActiveMembers.Margin = new Padding(4, 0, 4, 0);
            lblActiveMembers.Name = "lblActiveMembers";
            lblActiveMembers.Size = new Size(64, 74);
            lblActiveMembers.TabIndex = 1;
            lblActiveMembers.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblAttendanceLabel);
            panel1.Controls.Add(lblTotalAttendance);
            panel1.Location = new Point(1337, 12);
            panel1.Margin = new Padding(12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(19);
            panel1.Size = new Size(209, 156);
            panel1.TabIndex = 6;
            // 
            // lblAttendanceLabel
            // 
            lblAttendanceLabel.AutoSize = true;
            lblAttendanceLabel.Font = new Font("Segoe UI", 10F);
            lblAttendanceLabel.ForeColor = Color.FromArgb(100, 100, 100);
            lblAttendanceLabel.Location = new Point(40, 38);
            lblAttendanceLabel.Margin = new Padding(4, 0, 4, 0);
            lblAttendanceLabel.Name = "lblAttendanceLabel";
            lblAttendanceLabel.Size = new Size(159, 28);
            lblAttendanceLabel.TabIndex = 0;
            lblAttendanceLabel.Text = "Total Attendance";
            lblAttendanceLabel.Click += label1_Click;
            // 
            // lblTotalAttendance
            // 
            lblTotalAttendance.AutoSize = true;
            lblTotalAttendance.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalAttendance.ForeColor = Color.FromArgb(30, 30, 30);
            lblTotalAttendance.Location = new Point(66, 81);
            lblTotalAttendance.Margin = new Padding(4, 0, 4, 0);
            lblTotalAttendance.Name = "lblTotalAttendance";
            lblTotalAttendance.Size = new Size(64, 74);
            lblTotalAttendance.TabIndex = 1;
            lblTotalAttendance.Text = "0";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(tblDashboard);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "DashboardView";
            Size = new Size(1663, 683);
            Load += DashboardView_Load;
            tblDashboard.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlCards.ResumeLayout(false);
            flpCards.ResumeLayout(false);
            pnlMembers.ResumeLayout(false);
            pnlMembers.PerformLayout();
            pnlTrainers.ResumeLayout(false);
            pnlTrainers.PerformLayout();
            pnlPaid.ResumeLayout(false);
            pnlPaid.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlOverdue.ResumeLayout(false);
            pnlOverdue.PerformLayout();
            pnlActive.ResumeLayout(false);
            pnlActive.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tblDashboard;
        private Panel pnlTopBar;
        private Label lblWelcome;
        private Button btnRefresh;
        private Panel pnlCards;
        private FlowLayoutPanel flpCards;
        private Panel pnlMembers, pnlTrainers, pnlPaid, pnlPending, pnlOverdue, pnlActive;
        private Label lblMembersLabel, lblTotalMembers;
        private Label lblTrainersLabel, lblTotalTrainers;
        private Label lblPaidLabel, lblTotalPaid;
        private Label lblPendingLabel, lblTotalPending;
        private Label lblOverdueLabel, lblTotalOverdue;
        private Label lblActiveLabel, lblActiveMembers;
        private Panel panel1;
        private Label lblAttendanceLabel;
        private Label lblTotalAttendance;
    }
}
