namespace App.WindowsApp.Forms
{
    partial class TrainerForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tblTrainerForm = new TableLayoutPanel();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSpecialization = new Label();
            txtSpecialization = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblTrainerForm.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblTrainerForm
            // 
            tblTrainerForm.ColumnCount = 2;
            tblTrainerForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblTrainerForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tblTrainerForm.Controls.Add(lblId, 0, 0);
            tblTrainerForm.Controls.Add(txtId, 1, 0);
            tblTrainerForm.Controls.Add(lblName, 0, 1);
            tblTrainerForm.Controls.Add(txtName, 1, 1);
            tblTrainerForm.Controls.Add(lblPhone, 0, 2);
            tblTrainerForm.Controls.Add(txtPhone, 1, 2);
            tblTrainerForm.Controls.Add(lblEmail, 0, 3);
            tblTrainerForm.Controls.Add(txtEmail, 1, 3);
            tblTrainerForm.Controls.Add(lblSpecialization, 0, 4);
            tblTrainerForm.Controls.Add(txtSpecialization, 1, 4);
            tblTrainerForm.Dock = DockStyle.Top;
            tblTrainerForm.Location = new Point(0, 0);
            tblTrainerForm.Name = "tblTrainerForm";
            tblTrainerForm.RowCount = 5;
            tblTrainerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblTrainerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblTrainerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblTrainerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblTrainerForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblTrainerForm.Size = new Size(460, 250);
            tblTrainerForm.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 10F);
            lblId.ForeColor = Color.FromArgb(60, 60, 60);
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(155, 50);
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
            txtId.Location = new Point(164, 3);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(293, 34);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(60, 60, 60);
            lblName.Location = new Point(3, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(155, 50);
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
            txtName.Location = new Point(164, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 34);
            txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.FromArgb(60, 60, 60);
            lblPhone.Location = new Point(3, 100);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(155, 50);
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
            txtPhone.Location = new Point(164, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(293, 34);
            txtPhone.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(60, 60, 60);
            lblEmail.Location = new Point(3, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(155, 50);
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
            txtEmail.Location = new Point(164, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 34);
            txtEmail.TabIndex = 7;
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Dock = DockStyle.Fill;
            lblSpecialization.Font = new Font("Segoe UI", 10F);
            lblSpecialization.ForeColor = Color.FromArgb(60, 60, 60);
            lblSpecialization.Location = new Point(3, 200);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(155, 50);
            lblSpecialization.TabIndex = 8;
            lblSpecialization.Text = "Specialization:";
            lblSpecialization.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = Color.FromArgb(250, 250, 250);
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.Dock = DockStyle.Fill;
            txtSpecialization.Font = new Font("Segoe UI", 10F);
            txtSpecialization.Location = new Point(164, 203);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(293, 34);
            txtSpecialization.TabIndex = 9;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnSave);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(0, 250);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(460, 45);
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
            btnSave.Location = new Point(347, 3);
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
            btnCancel.ForeColor = Color.FromArgb(40, 40, 40);
            btnCancel.Image = Properties.Resources.icon_cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(231, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 295);
            Controls.Add(flpButtons);
            Controls.Add(tblTrainerForm);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Trainer Details";
            tblTrainerForm.ResumeLayout(false);
            tblTrainerForm.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tblTrainerForm;
        private Label lblId, lblName, lblPhone, lblEmail, lblSpecialization;
        private TextBox txtId, txtName, txtPhone, txtEmail, txtSpecialization;
        private FlowLayoutPanel flpButtons;
        private Button btnSave, btnCancel;
    }
}
