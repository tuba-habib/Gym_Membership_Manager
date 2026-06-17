namespace App.WindowsApp.Forms
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tblAttendanceForm = new TableLayoutPanel();
            lblMemberName = new Label();
            flpMemberName = new FlowLayoutPanel();
            txtMemberName = new TextBox();
            btnPickMember = new Button();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblTime = new Label();
            dtpTime = new DateTimePicker();
            lblNotes = new Label();
            txtNotes = new TextBox();
            flpAttendance = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblAttendanceForm.SuspendLayout();
            flpMemberName.SuspendLayout();
            flpAttendance.SuspendLayout();
            SuspendLayout();
            // 
            // tblAttendanceForm
            // 
            tblAttendanceForm.ColumnCount = 2;
            tblAttendanceForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblAttendanceForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblAttendanceForm.Controls.Add(lblMemberName, 0, 0);
            tblAttendanceForm.Controls.Add(flpMemberName, 1, 0);
            tblAttendanceForm.Controls.Add(lblDate, 0, 1);
            tblAttendanceForm.Controls.Add(dtpDate, 1, 1);
            tblAttendanceForm.Controls.Add(lblTime, 0, 2);
            tblAttendanceForm.Controls.Add(dtpTime, 1, 2);
            tblAttendanceForm.Controls.Add(lblNotes, 0, 3);
            tblAttendanceForm.Controls.Add(txtNotes, 1, 3);
            tblAttendanceForm.Dock = DockStyle.Fill;
            tblAttendanceForm.Location = new Point(0, 0);
            tblAttendanceForm.Name = "tblAttendanceForm";
            tblAttendanceForm.RowCount = 4;
            tblAttendanceForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAttendanceForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAttendanceForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAttendanceForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblAttendanceForm.Size = new Size(868, 353);
            tblAttendanceForm.TabIndex = 0;
            // 
            // lblMemberName
            // 
            lblMemberName.Anchor = AnchorStyles.Left;
            lblMemberName.AutoSize = true;
            lblMemberName.Location = new Point(3, 31);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(135, 25);
            lblMemberName.TabIndex = 0;
            lblMemberName.Text = "Member Name:";
            // 
            // flpMemberName
            // 
            flpMemberName.Controls.Add(txtMemberName);
            flpMemberName.Controls.Add(btnPickMember);
            flpMemberName.Dock = DockStyle.Fill;
            flpMemberName.Location = new Point(263, 3);
            flpMemberName.Name = "flpMemberName";
            flpMemberName.Size = new Size(602, 82);
            flpMemberName.TabIndex = 1;
            // 
            // txtMemberName
            // 
            txtMemberName.BackColor = Color.FromArgb(235, 235, 235);
            txtMemberName.Location = new Point(3, 3);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(470, 31);
            txtMemberName.TabIndex = 0;
            // 
            // btnPickMember
            // 
            btnPickMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPickMember.Image = Properties.Resources.icon_select;
            btnPickMember.ImageAlign = ContentAlignment.MiddleLeft;
            btnPickMember.Location = new Point(479, 3);
            btnPickMember.Name = "btnPickMember";
            btnPickMember.Size = new Size(120, 36);
            btnPickMember.TabIndex = 1;
            btnPickMember.Text = "Pick";
            btnPickMember.TextAlign = ContentAlignment.MiddleRight;
            btnPickMember.UseVisualStyleBackColor = true;
            btnPickMember.Click += btnPickMember_Click;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 119);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(127, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "Check-In Date:";
            // 
            // dtpDate
            // 
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(263, 91);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(602, 31);
            dtpDate.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.Location = new Point(3, 207);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(128, 25);
            lblTime.TabIndex = 4;
            lblTime.Text = "Check-In Time:";
            // 
            // dtpTime
            // 
            dtpTime.Dock = DockStyle.Fill;
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(263, 179);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(602, 31);
            dtpTime.TabIndex = 5;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Left;
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(3, 296);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(63, 25);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(263, 267);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(602, 83);
            txtNotes.TabIndex = 7;
            // 
            // flpAttendance
            // 
            flpAttendance.Controls.Add(btnSave);
            flpAttendance.Controls.Add(btnCancel);
            flpAttendance.Dock = DockStyle.Bottom;
            flpAttendance.FlowDirection = FlowDirection.RightToLeft;
            flpAttendance.Location = new Point(0, 353);
            flpAttendance.Name = "flpAttendance";
            flpAttendance.Padding = new Padding(5);
            flpAttendance.Size = new Size(868, 128);
            flpAttendance.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources.icon_save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(735, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Image = Properties.Resources.icon_cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(603, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 49);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 481);
            Controls.Add(tblAttendanceForm);
            Controls.Add(flpAttendance);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            tblAttendanceForm.ResumeLayout(false);
            tblAttendanceForm.PerformLayout();
            flpMemberName.ResumeLayout(false);
            flpMemberName.PerformLayout();
            flpAttendance.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tblAttendanceForm;
        private FlowLayoutPanel flpAttendance;
        private Button btnSave;
        private Button btnCancel;
        private Button btnPickMember;
        private Label lblMemberName;
        private Label lblDate;
        private Label lblTime;
        private Label lblNotes;
        private FlowLayoutPanel flpMemberName;
        private TextBox txtMemberName;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpTime;
        private TextBox txtNotes;
    }
}
