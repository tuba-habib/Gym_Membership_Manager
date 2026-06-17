namespace App.WindowsApp.Forms
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tblPaymentForm = new TableLayoutPanel();
            lblMember = new Label();
            flpMember = new FlowLayoutPanel();
            txtMemberId = new TextBox();
            txtMemberName = new TextBox();
            btnPickMember = new Button();
            lblTrainer = new Label();
            flpTrainer = new FlowLayoutPanel();
            txtTrainerId = new TextBox();
            txtTrainerName = new TextBox();
            btnPickTrainer = new Button();
            lblPaymentDate = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            flpButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblPaymentForm.SuspendLayout();
            flpMember.SuspendLayout();
            flpTrainer.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblPaymentForm
            // 
            tblPaymentForm.ColumnCount = 2;
            tblPaymentForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblPaymentForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblPaymentForm.Controls.Add(lblMember, 0, 0);
            tblPaymentForm.Controls.Add(flpMember, 1, 0);
            tblPaymentForm.Controls.Add(lblTrainer, 0, 1);
            tblPaymentForm.Controls.Add(flpTrainer, 1, 1);
            tblPaymentForm.Controls.Add(lblPaymentDate, 0, 2);
            tblPaymentForm.Controls.Add(dtpPaymentDate, 1, 2);
            tblPaymentForm.Controls.Add(lblDueDate, 0, 3);
            tblPaymentForm.Controls.Add(dtpDueDate, 1, 3);
            tblPaymentForm.Controls.Add(lblStatus, 0, 4);
            tblPaymentForm.Controls.Add(cmbStatus, 1, 4);
            tblPaymentForm.Dock = DockStyle.Top;
            tblPaymentForm.Location = new Point(0, 0);
            tblPaymentForm.Name = "tblPaymentForm";
            tblPaymentForm.RowCount = 5;
            tblPaymentForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblPaymentForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblPaymentForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblPaymentForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblPaymentForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblPaymentForm.Size = new Size(500, 225);
            tblPaymentForm.TabIndex = 0;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Dock = DockStyle.Fill;
            lblMember.Font = new Font("Segoe UI", 10F);
            lblMember.ForeColor = Color.FromArgb(60, 60, 60);
            lblMember.Location = new Point(3, 0);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(144, 45);
            lblMember.TabIndex = 0;
            lblMember.Text = "Member:";
            lblMember.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpMember
            // 
            flpMember.Controls.Add(txtMemberId);
            flpMember.Controls.Add(txtMemberName);
            flpMember.Controls.Add(btnPickMember);
            flpMember.Dock = DockStyle.Fill;
            flpMember.Location = new Point(153, 3);
            flpMember.Name = "flpMember";
            flpMember.Size = new Size(344, 39);
            flpMember.TabIndex = 1;
            // 
            // txtMemberId
            // 
            txtMemberId.BackColor = Color.FromArgb(235, 235, 235);
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Font = new Font("Segoe UI", 10F);
            txtMemberId.Location = new Point(3, 3);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(80, 34);
            txtMemberId.TabIndex = 0;
            // 
            // txtMemberName
            // 
            txtMemberName.BackColor = Color.FromArgb(235, 235, 235);
            txtMemberName.BorderStyle = BorderStyle.FixedSingle;
            txtMemberName.Font = new Font("Segoe UI", 10F);
            txtMemberName.Location = new Point(89, 3);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(160, 34);
            txtMemberName.TabIndex = 1;
            // 
            // btnPickMember
            // 
            btnPickMember.BackColor = Color.FromArgb(80, 80, 80);
            btnPickMember.FlatAppearance.BorderSize = 0;
            btnPickMember.FlatStyle = FlatStyle.Flat;
            btnPickMember.Font = new Font("Segoe UI", 9F);
            btnPickMember.ForeColor = Color.White;
            btnPickMember.Location = new Point(255, 3);
            btnPickMember.Name = "btnPickMember";
            btnPickMember.Size = new Size(65, 30);
            btnPickMember.TabIndex = 2;
            btnPickMember.Text = "Pick";
            btnPickMember.UseVisualStyleBackColor = false;
            btnPickMember.Click += btnPickMember_Click;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Dock = DockStyle.Fill;
            lblTrainer.Font = new Font("Segoe UI", 10F);
            lblTrainer.ForeColor = Color.FromArgb(60, 60, 60);
            lblTrainer.Location = new Point(3, 45);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(144, 45);
            lblTrainer.TabIndex = 2;
            lblTrainer.Text = "Trainer:";
            lblTrainer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpTrainer
            // 
            flpTrainer.Controls.Add(txtTrainerId);
            flpTrainer.Controls.Add(txtTrainerName);
            flpTrainer.Controls.Add(btnPickTrainer);
            flpTrainer.Dock = DockStyle.Fill;
            flpTrainer.Location = new Point(153, 48);
            flpTrainer.Name = "flpTrainer";
            flpTrainer.Size = new Size(344, 39);
            flpTrainer.TabIndex = 3;
            // 
            // txtTrainerId
            // 
            txtTrainerId.BackColor = Color.FromArgb(235, 235, 235);
            txtTrainerId.BorderStyle = BorderStyle.FixedSingle;
            txtTrainerId.Font = new Font("Segoe UI", 10F);
            txtTrainerId.Location = new Point(3, 3);
            txtTrainerId.Name = "txtTrainerId";
            txtTrainerId.ReadOnly = true;
            txtTrainerId.Size = new Size(80, 34);
            txtTrainerId.TabIndex = 0;
            // 
            // txtTrainerName
            // 
            txtTrainerName.BackColor = Color.FromArgb(235, 235, 235);
            txtTrainerName.BorderStyle = BorderStyle.FixedSingle;
            txtTrainerName.Font = new Font("Segoe UI", 10F);
            txtTrainerName.Location = new Point(89, 3);
            txtTrainerName.Name = "txtTrainerName";
            txtTrainerName.ReadOnly = true;
            txtTrainerName.Size = new Size(160, 34);
            txtTrainerName.TabIndex = 1;
            // 
            // btnPickTrainer
            // 
            btnPickTrainer.BackColor = Color.FromArgb(80, 80, 80);
            btnPickTrainer.FlatAppearance.BorderSize = 0;
            btnPickTrainer.FlatStyle = FlatStyle.Flat;
            btnPickTrainer.Font = new Font("Segoe UI", 9F);
            btnPickTrainer.ForeColor = Color.White;
            btnPickTrainer.Location = new Point(255, 3);
            btnPickTrainer.Name = "btnPickTrainer";
            btnPickTrainer.Size = new Size(65, 30);
            btnPickTrainer.TabIndex = 2;
            btnPickTrainer.Text = "Pick";
            btnPickTrainer.UseVisualStyleBackColor = false;
            btnPickTrainer.Click += btnPickTrainer_Click;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Dock = DockStyle.Fill;
            lblPaymentDate.Font = new Font("Segoe UI", 10F);
            lblPaymentDate.ForeColor = Color.FromArgb(60, 60, 60);
            lblPaymentDate.Location = new Point(3, 90);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(144, 45);
            lblPaymentDate.TabIndex = 4;
            lblPaymentDate.Text = "Payment Date:";
            lblPaymentDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Dock = DockStyle.Fill;
            dtpPaymentDate.Font = new Font("Segoe UI", 10F);
            dtpPaymentDate.Location = new Point(153, 93);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(344, 34);
            dtpPaymentDate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Dock = DockStyle.Fill;
            lblDueDate.Font = new Font("Segoe UI", 10F);
            lblDueDate.ForeColor = Color.FromArgb(60, 60, 60);
            lblDueDate.Location = new Point(3, 135);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(144, 45);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Due Date:";
            lblDueDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Dock = DockStyle.Fill;
            dtpDueDate.Font = new Font("Segoe UI", 10F);
            dtpDueDate.Location = new Point(153, 138);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(344, 34);
            dtpDueDate.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatus.Location = new Point(3, 180);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 45);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.Location = new Point(153, 183);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(344, 36);
            cmbStatus.TabIndex = 9;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnSave);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(0, 225);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(500, 50);
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
            btnSave.Location = new Point(387, 3);
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
            btnCancel.Location = new Point(271, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 275);
            Controls.Add(flpButtons);
            Controls.Add(tblPaymentForm);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment Details";
            tblPaymentForm.ResumeLayout(false);
            tblPaymentForm.PerformLayout();
            flpMember.ResumeLayout(false);
            flpMember.PerformLayout();
            flpTrainer.ResumeLayout(false);
            flpTrainer.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tblPaymentForm;
        private Label lblMember, lblTrainer, lblPaymentDate, lblDueDate, lblStatus;
        private FlowLayoutPanel flpMember;
        private TextBox txtMemberId, txtMemberName;
        private Button btnPickMember;
        private FlowLayoutPanel flpTrainer;
        private TextBox txtTrainerId, txtTrainerName;
        private Button btnPickTrainer;
        private DateTimePicker dtpPaymentDate, dtpDueDate;
        private ComboBox cmbStatus;
        private FlowLayoutPanel flpButtons;
        private Button btnSave, btnCancel;
    }
}
