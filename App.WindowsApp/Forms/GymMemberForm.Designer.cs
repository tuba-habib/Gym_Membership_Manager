namespace App.WindowsApp.Forms
{
    partial class GymMemberForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tblMemberForm = new TableLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPlan = new Label();
            cmbPlan = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblJoinDate = new Label();
            dtpJoinDate = new DateTimePicker();
            flpButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblMemberForm.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMemberForm
            // 
            tblMemberForm.ColumnCount = 2;
            tblMemberForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblMemberForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tblMemberForm.Controls.Add(lblId, 0, 0);
            tblMemberForm.Controls.Add(txtId, 1, 0);
            tblMemberForm.Controls.Add(lblName, 0, 1);
            tblMemberForm.Controls.Add(txtName, 1, 1);
            tblMemberForm.Controls.Add(lblPhone, 0, 2);
            tblMemberForm.Controls.Add(txtPhone, 1, 2);
            tblMemberForm.Controls.Add(lblEmail, 0, 3);
            tblMemberForm.Controls.Add(txtEmail, 1, 3);
            tblMemberForm.Controls.Add(lblAddress, 0, 4);
            tblMemberForm.Controls.Add(txtAddress, 1, 4);
            tblMemberForm.Controls.Add(lblPlan, 0, 5);
            tblMemberForm.Controls.Add(cmbPlan, 1, 5);
            tblMemberForm.Controls.Add(lblStatus, 0, 6);
            tblMemberForm.Controls.Add(cmbStatus, 1, 6);
            tblMemberForm.Controls.Add(lblJoinDate, 0, 7);
            tblMemberForm.Controls.Add(dtpJoinDate, 1, 7);
            tblMemberForm.Dock = DockStyle.Top;
            tblMemberForm.Location = new Point(0, 0);
            tblMemberForm.Name = "tblMemberForm";
            tblMemberForm.RowCount = 8;
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblMemberForm.Size = new Size(439, 360);
            tblMemberForm.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.ForeColor = Color.FromArgb(60, 60, 60);
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(147, 45);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(235, 235, 235);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Dock = DockStyle.Fill;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(156, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(280, 34);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(60, 60, 60);
            lblName.Location = new Point(3, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(147, 45);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(250, 250, 250);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(156, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 34);
            txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.FromArgb(60, 60, 60);
            lblPhone.Location = new Point(3, 90);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(147, 45);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone:";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(250, 250, 250);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(156, 93);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 34);
            txtPhone.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(60, 60, 60);
            lblEmail.Location = new Point(3, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(147, 45);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(250, 250, 250);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(156, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 34);
            txtEmail.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.ForeColor = Color.FromArgb(60, 60, 60);
            lblAddress.Location = new Point(3, 180);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(147, 45);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(250, 250, 250);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(156, 183);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 34);
            txtAddress.TabIndex = 9;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Dock = DockStyle.Fill;
            lblPlan.Font = new Font("Segoe UI", 10F);
            lblPlan.ForeColor = Color.FromArgb(60, 60, 60);
            lblPlan.Location = new Point(3, 225);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(147, 45);
            lblPlan.TabIndex = 10;
            lblPlan.Text = "Membership Plan:";
            lblPlan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbPlan
            // 
            cmbPlan.Dock = DockStyle.Fill;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FlatStyle = FlatStyle.Flat;
            cmbPlan.Font = new Font("Segoe UI", 10F);
            cmbPlan.Location = new Point(156, 228);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(280, 36);
            cmbPlan.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatus.Location = new Point(3, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(147, 45);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.Location = new Point(156, 273);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(280, 36);
            cmbStatus.TabIndex = 13;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Dock = DockStyle.Fill;
            lblJoinDate.Font = new Font("Segoe UI", 10F);
            lblJoinDate.ForeColor = Color.FromArgb(60, 60, 60);
            lblJoinDate.Location = new Point(3, 315);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(147, 45);
            lblJoinDate.TabIndex = 14;
            lblJoinDate.Text = "Join Date:";
            lblJoinDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Dock = DockStyle.Fill;
            dtpJoinDate.Font = new Font("Segoe UI", 10F);
            dtpJoinDate.Location = new Point(156, 318);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(280, 34);
            dtpJoinDate.TabIndex = 15;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnSave);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(0, 360);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(439, 55);
            flpButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources.icon_save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(326, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(200, 200, 200);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.icon_cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(210, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // GymMemberForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 415);
            Controls.Add(flpButtons);
            Controls.Add(tblMemberForm);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GymMemberForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Member Details";
            tblMemberForm.ResumeLayout(false);
            tblMemberForm.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tblMemberForm;
        private Label lblId, lblName, lblPhone, lblEmail, lblAddress, lblPlan, lblStatus, lblJoinDate;
        private TextBox txtId, txtName, txtPhone, txtEmail, txtAddress;
        private ComboBox cmbPlan, cmbStatus;
        private DateTimePicker dtpJoinDate;
        private FlowLayoutPanel flpButtons;
        private Button btnSave, btnCancel;
    }
}
