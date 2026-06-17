namespace App.WindowsApp.Views
{
    partial class GymMembersView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tblMembers = new TableLayoutPanel();
            pnlToolbar = new Panel();
            toolStrip = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilter = new Panel();
            tblFilters = new TableLayoutPanel();
            lblSearch = new Label();
            lblPlan = new Label();
            lblStatus = new Label();
            txtSearch = new TextBox();
            cmbPlan = new ComboBox();
            cmbStatus = new ComboBox();
            pnlGrid = new Panel();
            dgvMembers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colJoinDate = new DataGridViewTextBoxColumn();
            tblMembers.SuspendLayout();
            pnlToolbar.SuspendLayout();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // tblMembers
            // 
            tblMembers.ColumnCount = 1;
            tblMembers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMembers.Controls.Add(pnlToolbar, 0, 0);
            tblMembers.Controls.Add(pnlFilter, 0, 1);
            tblMembers.Controls.Add(pnlGrid, 0, 2);
            tblMembers.Dock = DockStyle.Fill;
            tblMembers.Location = new Point(0, 0);
            tblMembers.Name = "tblMembers";
            tblMembers.RowCount = 3;
            tblMembers.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMembers.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tblMembers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMembers.Size = new Size(875, 590);
            tblMembers.TabIndex = 0;
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
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(869, 34);
            toolStrip.TabIndex = 0;
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.icon_add;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(70, 29);
            tsbAdd.Text = "Add";
            tsbAdd.TextAlign = ContentAlignment.MiddleRight;
            tsbAdd.Click += tsbAdd_Click;
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
            // tsbView
            // 
            tsbView.Image = Properties.Resources.icon_view;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(73, 29);
            tsbView.Text = "View";
            tsbView.TextAlign = ContentAlignment.MiddleRight;
            tsbView.Click += tsbView_Click;
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
            pnlFilter.Controls.Add(tblFilters);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(4, 44);
            pnlFilter.Margin = new Padding(4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(6);
            pnlFilter.Size = new Size(867, 82);
            pnlFilter.TabIndex = 1;
            // 
            // tblFilters
            // 
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Controls.Add(lblPlan, 1, 0);
            tblFilters.Controls.Add(lblStatus, 2, 0);
            tblFilters.Controls.Add(txtSearch, 0, 1);
            tblFilters.Controls.Add(cmbPlan, 1, 1);
            tblFilters.Controls.Add(cmbStatus, 2, 1);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(6, 6);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFilters.Size = new Size(853, 68);
            tblFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(333, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Dock = DockStyle.Fill;
            lblPlan.ForeColor = Color.FromArgb(60, 60, 60);
            lblPlan.Location = new Point(345, 0);
            lblPlan.Margin = new Padding(4, 0, 4, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(247, 28);
            lblPlan.TabIndex = 2;
            lblPlan.Text = "Plan:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblStatus.Location = new Point(600, 0);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(249, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(4, 32);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(333, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbPlan
            // 
            cmbPlan.Dock = DockStyle.Fill;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FlatStyle = FlatStyle.Flat;
            cmbPlan.Location = new Point(345, 32);
            cmbPlan.Margin = new Padding(4);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(247, 33);
            cmbPlan.TabIndex = 3;
            cmbPlan.SelectedIndexChanged += cmbPlan_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Location = new Point(600, 32);
            cmbStatus.Margin = new Padding(4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(249, 33);
            cmbStatus.TabIndex = 5;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvMembers);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 133);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(869, 454);
            pnlGrid.TabIndex = 2;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colAddress, colPlan, colStatus, colJoinDate });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.GridColor = Color.FromArgb(220, 220, 220);
            dgvMembers.Location = new Point(0, 0);
            dgvMembers.Margin = new Padding(4);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 62;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(869, 454);
            dgvMembers.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 8;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colPlan
            // 
            colPlan.DataPropertyName = "Plan";
            colPlan.HeaderText = "Plan";
            colPlan.MinimumWidth = 8;
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colJoinDate
            // 
            colJoinDate.DataPropertyName = "JoinDate";
            colJoinDate.HeaderText = "JoinDate";
            colJoinDate.MinimumWidth = 8;
            colJoinDate.Name = "colJoinDate";
            colJoinDate.ReadOnly = true;
            // 
            // GymMembersView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(tblMembers);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "GymMembersView";
            Size = new Size(875, 590);
            Load += GymMembersView_Load;
            tblMembers.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tblMembers;
        private Panel pnlToolbar;
        private ToolStrip toolStrip;
        private ToolStripButton tsbAdd, tsbEdit, tsbView, tsbDelete, tsbRefresh;
        private ToolStripSeparator toolStripSeparator1;
        private Panel pnlFilter;
        private TableLayoutPanel tblFilters;
        private Label lblSearch, lblPlan, lblStatus;
        private TextBox txtSearch;
        private ComboBox cmbPlan, cmbStatus;
        private Panel pnlGrid;
        private DataGridView dgvMembers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colJoinDate;
    }
}
