namespace App.WindowsApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            lblTitle = new Label();
            picLogo = new PictureBox();
            pnlSidebar = new Panel();
            flpNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnMembers = new Button();
            btnTrainers = new Button();
            btnPayments = new Button();
            btnAttendance = new Button();
            statusStrip = new StatusStrip();
            tsLabelStatus = new ToolStripStatusLabel();
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            flpNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightGray;
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1125, 69);
            pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(1003, 0);
            flpRight.Margin = new Padding(4);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(122, 69);
            flpRight.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Right;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(4, 0);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(74, 28);
            lblUser.TabIndex = 0;
            lblUser.Text = "Admin";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(lblTitle);
            flpLeft.Controls.Add(picLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.FlowDirection = FlowDirection.RightToLeft;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(4);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(494, 69);
            flpLeft.TabIndex = 0;
            flpLeft.Paint += flpLeft_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(88, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(402, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Gym Membership Manager";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Click += lblTitle_Click;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.icon_gym;
            picLogo.Location = new Point(4, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(77, 59);
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(45, 45, 45);
            pnlSidebar.Controls.Add(flpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 69);
            pnlSidebar.Margin = new Padding(4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(231, 631);
            pnlSidebar.TabIndex = 1;
            // 
            // flpNav
            // 
            flpNav.BackColor = Color.White;
            flpNav.Controls.Add(btnDashboard);
            flpNav.Controls.Add(btnMembers);
            flpNav.Controls.Add(btnTrainers);
            flpNav.Controls.Add(btnPayments);
            flpNav.Controls.Add(btnAttendance);
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(0, 0);
            flpNav.Margin = new Padding(4);
            flpNav.Name = "flpNav";
            flpNav.Padding = new Padding(6, 15, 6, 0);
            flpNav.Size = new Size(231, 631);
            flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkGray;
            btnDashboard.FlatAppearance.BorderColor = Color.White;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = Properties.Resources.icon_dashboard;
            btnDashboard.Location = new Point(10, 19);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(210, 55);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.DarkGray;
            btnMembers.FlatAppearance.BorderColor = Color.White;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI", 10F);
            btnMembers.ForeColor = Color.Black;
            btnMembers.Image = Properties.Resources.icon_members;
            btnMembers.Location = new Point(10, 82);
            btnMembers.Margin = new Padding(4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(210, 55);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "   Members";
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnTrainers
            // 
            btnTrainers.BackColor = Color.DarkGray;
            btnTrainers.FlatAppearance.BorderColor = Color.White;
            btnTrainers.FlatAppearance.BorderSize = 0;
            btnTrainers.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnTrainers.FlatStyle = FlatStyle.Flat;
            btnTrainers.Font = new Font("Segoe UI", 10F);
            btnTrainers.ForeColor = Color.Black;
            btnTrainers.Image = Properties.Resources.icon_trainers;
            btnTrainers.Location = new Point(10, 145);
            btnTrainers.Margin = new Padding(4);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Size = new Size(210, 55);
            btnTrainers.TabIndex = 2;
            btnTrainers.Text = "   Trainers";
            btnTrainers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrainers.UseVisualStyleBackColor = false;
            btnTrainers.Click += btnTrainers_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.DarkGray;
            btnPayments.FlatAppearance.BorderColor = Color.White;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 10F);
            btnPayments.ForeColor = Color.Black;
            btnPayments.Image = Properties.Resources.icon_payments;
            btnPayments.Location = new Point(10, 208);
            btnPayments.Margin = new Padding(4);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(211, 55);
            btnPayments.TabIndex = 3;
            btnPayments.Text = "   Payments";
            btnPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.DarkGray;
            btnAttendance.FlatAppearance.BorderColor = Color.White;
            btnAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.Black;
            btnAttendance.Image = Properties.Resources.icon_attendance;
            btnAttendance.Location = new Point(10, 271);
            btnAttendance.Margin = new Padding(4);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(210, 55);
            btnAttendance.TabIndex = 4;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(30, 30, 30);
            statusStrip.ForeColor = Color.FromArgb(180, 180, 180);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { tsLabelStatus });
            statusStrip.Location = new Point(0, 700);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 18, 0);
            statusStrip.Size = new Size(1125, 32);
            statusStrip.TabIndex = 2;
            // 
            // tsLabelStatus
            // 
            tsLabelStatus.ForeColor = Color.FromArgb(180, 180, 180);
            tsLabelStatus.Name = "tsLabelStatus";
            tsLabelStatus.Size = new Size(60, 25);
            tsLabelStatus.Text = "Ready";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(231, 69);
            pnlContent.Margin = new Padding(4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(894, 631);
            pnlContent.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 732);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Membership Manager";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            flpNav.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlHeader;
        private FlowLayoutPanel flpRight;
        private FlowLayoutPanel flpLeft;
        private Label lblTitle;
        private Label lblUser;
        private Panel pnlSidebar;
        private FlowLayoutPanel flpNav;
        private Button btnDashboard;
        private Button btnMembers;
        private Button btnTrainers;
        private Button btnPayments;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tsLabelStatus;
        private Panel pnlContent;
        private Button btnAttendance;
        private PictureBox picLogo;
    }
}
