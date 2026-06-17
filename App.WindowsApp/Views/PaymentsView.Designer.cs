namespace App.WindowsApp.Views
{
    partial class PaymentsView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tblPayments = new TableLayoutPanel();
            pnlToolbar = new Panel();
            toolStrip = new ToolStrip();
            tsbAddPayment = new ToolStripButton();
            tsbMarkPaid = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilter = new Panel();
            flpFilter = new FlowLayoutPanel();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            pnlGrid = new Panel();
            dgvPayments = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colMemberId = new DataGridViewTextBoxColumn();
            colMemberName = new DataGridViewTextBoxColumn();
            colTrainerId = new DataGridViewTextBoxColumn();
            colTrainerName = new DataGridViewTextBoxColumn();
            colPaymentDate = new DataGridViewTextBoxColumn();
            colDueDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblPayments.SuspendLayout();
            pnlToolbar.SuspendLayout();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            flpFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // tblPayments
            // 
            tblPayments.ColumnCount = 1;
            tblPayments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPayments.Controls.Add(pnlToolbar, 0, 0);
            tblPayments.Controls.Add(pnlFilter, 0, 1);
            tblPayments.Controls.Add(pnlGrid, 0, 2);
            tblPayments.Dock = DockStyle.Fill;
            tblPayments.Location = new Point(0, 0);
            tblPayments.Name = "tblPayments";
            tblPayments.RowCount = 3;
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPayments.Size = new Size(875, 590);
            tblPayments.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(230, 230, 230);
            pnlToolbar.Controls.Add(toolStrip);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Location = new Point(3, 3);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(869, 34);
            pnlToolbar.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.FromArgb(230, 230, 230);
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbAddPayment, tsbMarkPaid, tsbEdit, tsbDelete, toolStripSeparator1, tsbRefresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(869, 34);
            toolStrip.TabIndex = 0;
            // 
            // tsbAddPayment
            // 
            tsbAddPayment.Image = Properties.Resources.icon_addpayments;
            tsbAddPayment.Name = "tsbAddPayment";
            tsbAddPayment.Size = new Size(143, 29);
            tsbAddPayment.Text = "Add Payment";
            tsbAddPayment.TextAlign = ContentAlignment.MiddleRight;
            tsbAddPayment.Click += tsbAddPayment_Click;
            // 
            // tsbMarkPaid
            // 
            tsbMarkPaid.Image = Properties.Resources.icon_markpaid;
            tsbMarkPaid.Name = "tsbMarkPaid";
            tsbMarkPaid.Size = new Size(114, 29);
            tsbMarkPaid.Text = "Mark Paid";
            tsbMarkPaid.TextAlign = ContentAlignment.MiddleRight;
            tsbMarkPaid.Click += tsbMarkPaid_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.icon_edit;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(66, 29);
            tsbEdit.Text = "Edit";
            tsbEdit.TextAlign = ContentAlignment.MiddleRight;
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.icon_delete;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(86, 29);
            tsbDelete.Text = "Delete";
            tsbDelete.TextAlign = ContentAlignment.MiddleRight;
            tsbDelete.Click += tsbDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.icon_refresh;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(94, 29);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.TextAlign = ContentAlignment.MiddleRight;
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderStyle = BorderStyle.FixedSingle;
            pnlFilter.Controls.Add(flpFilter);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(4, 44);
            pnlFilter.Margin = new Padding(4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(6);
            pnlFilter.Size = new Size(867, 57);
            pnlFilter.TabIndex = 1;
            // 
            // flpFilter
            // 
            flpFilter.Controls.Add(lblStatusFilter);
            flpFilter.Controls.Add(cmbStatusFilter);
            flpFilter.Dock = DockStyle.Fill;
            flpFilter.Location = new Point(6, 6);
            flpFilter.Name = "flpFilter";
            flpFilter.Size = new Size(853, 43);
            flpFilter.TabIndex = 0;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatusFilter.Location = new Point(4, 0);
            lblStatusFilter.Margin = new Padding(4, 0, 4, 0);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(64, 25);
            lblStatusFilter.TabIndex = 0;
            lblStatusFilter.Text = "Status:";
            lblStatusFilter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FlatStyle = FlatStyle.Flat;
            cmbStatusFilter.Location = new Point(76, 4);
            cmbStatusFilter.Margin = new Padding(4);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(224, 33);
            cmbStatusFilter.TabIndex = 1;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvPayments);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 108);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(869, 479);
            pnlGrid.TabIndex = 2;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 248, 248);
            dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { colId, colMemberId, colMemberName, colTrainerId, colTrainerName, colPaymentDate, colDueDate, colStatus });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle7;
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.FromArgb(220, 220, 220);
            dgvPayments.Location = new Point(0, 0);
            dgvPayments.Margin = new Padding(4);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidth = 62;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(869, 479);
            dgvPayments.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colMemberId
            // 
            colMemberId.DataPropertyName = "MemberId";
            colMemberId.HeaderText = "MemberId";
            colMemberId.MinimumWidth = 8;
            colMemberId.Name = "colMemberId";
            colMemberId.ReadOnly = true;
            // 
            // colMemberName
            // 
            colMemberName.DataPropertyName = "MemberName";
            colMemberName.HeaderText = "MemberName";
            colMemberName.MinimumWidth = 8;
            colMemberName.Name = "colMemberName";
            colMemberName.ReadOnly = true;
            // 
            // colTrainerId
            // 
            colTrainerId.DataPropertyName = "TrainerId";
            colTrainerId.HeaderText = "TrainerId";
            colTrainerId.MinimumWidth = 8;
            colTrainerId.Name = "colTrainerId";
            colTrainerId.ReadOnly = true;
            // 
            // colTrainerName
            // 
            colTrainerName.DataPropertyName = "TrainerName";
            colTrainerName.HeaderText = "TrainerName";
            colTrainerName.MinimumWidth = 8;
            colTrainerName.Name = "colTrainerName";
            colTrainerName.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            colPaymentDate.DataPropertyName = "PaymentDate";
            colPaymentDate.HeaderText = "PaymentDate";
            colPaymentDate.MinimumWidth = 8;
            colPaymentDate.Name = "colPaymentDate";
            colPaymentDate.ReadOnly = true;
            // 
            // colDueDate
            // 
            colDueDate.DataPropertyName = "DueDate";
            colDueDate.HeaderText = "DueDate";
            colDueDate.MinimumWidth = 8;
            colDueDate.Name = "colDueDate";
            colDueDate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // PaymentsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(tblPayments);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "PaymentsView";
            Size = new Size(875, 590);
            tblPayments.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            flpFilter.ResumeLayout(false);
            flpFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tblPayments;
        private Panel pnlToolbar;
        private ToolStrip toolStrip;
        private ToolStripButton tsbAddPayment;
        private ToolStripButton tsbMarkPaid;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRefresh;
        private Panel pnlFilter;
        private FlowLayoutPanel flpFilter;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private Panel pnlGrid;
        private DataGridView dgvPayments;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colMemberName;
        private DataGridViewTextBoxColumn colTrainerId;
        private DataGridViewTextBoxColumn colTrainerName;
        private DataGridViewTextBoxColumn colPaymentDate;
        private DataGridViewTextBoxColumn colDueDate;
        private DataGridViewTextBoxColumn colStatus;
    }
}
