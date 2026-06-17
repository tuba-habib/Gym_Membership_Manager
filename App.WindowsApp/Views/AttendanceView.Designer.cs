namespace App.WindowsApp.Views
{
    partial class AttendanceView
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
            tblAttendance = new TableLayoutPanel();
            pnlToolbar = new Panel();
            toolStrip = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnView = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            btnRefresh = new ToolStripButton();
            pnlFilter = new Panel();
            flpFilter = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlGrid = new Panel();
            dgvAttendance = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colMemberId = new DataGridViewTextBoxColumn();
            colMemberName = new DataGridViewTextBoxColumn();
            colCheckInDate = new DataGridViewTextBoxColumn();
            colCheckInTime = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            tblAttendance.SuspendLayout();
            pnlToolbar.SuspendLayout();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            flpFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // tblAttendance
            // 
            tblAttendance.ColumnCount = 1;
            tblAttendance.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblAttendance.Controls.Add(pnlToolbar, 0, 0);
            tblAttendance.Controls.Add(pnlFilter, 0, 1);
            tblAttendance.Controls.Add(pnlGrid, 0, 2);
            tblAttendance.Dock = DockStyle.Fill;
            tblAttendance.Location = new Point(0, 0);
            tblAttendance.Name = "tblAttendance";
            tblAttendance.RowCount = 3;
            tblAttendance.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAttendance.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblAttendance.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAttendance.Size = new Size(968, 531);
            tblAttendance.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(230, 230, 230);
            pnlToolbar.Controls.Add(toolStrip);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Location = new Point(3, 3);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(962, 34);
            pnlToolbar.TabIndex = 0;
            // 
            // toolStrip
            // 
            toolStrip.BackColor = Color.FromArgb(230, 230, 230);
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnView, btnDelete, toolStripSeparator, btnRefresh });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(962, 34);
            toolStrip.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.icon_add;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 29);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.icon_edit;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(66, 29);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnView
            // 
            btnView.Image = Properties.Resources.icon_view;
            btnView.Name = "btnView";
            btnView.Size = new Size(73, 29);
            btnView.Text = "View";
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.icon_delete;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 29);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 34);
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.icon_refresh;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
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
            pnlFilter.Size = new Size(960, 57);
            pnlFilter.TabIndex = 1;
            // 
            // flpFilter
            // 
            flpFilter.Controls.Add(lblSearch);
            flpFilter.Controls.Add(txtSearch);
            flpFilter.Dock = DockStyle.Fill;
            flpFilter.Location = new Point(6, 6);
            flpFilter.Name = "flpFilter";
            flpFilter.Size = new Size(946, 43);
            flpFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(80, 4);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvAttendance);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 108);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(962, 420);
            pnlGrid.TabIndex = 2;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colId, colMemberId, colMemberName, colCheckInDate, colCheckInTime, colNotes });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = Color.FromArgb(220, 220, 220);
            dgvAttendance.Location = new Point(0, 0);
            dgvAttendance.Margin = new Padding(4);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 62;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(962, 420);
            dgvAttendance.TabIndex = 0;
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
            // colCheckInDate
            // 
            colCheckInDate.DataPropertyName = "CheckInDate";
            colCheckInDate.HeaderText = "CheckInDate";
            colCheckInDate.MinimumWidth = 8;
            colCheckInDate.Name = "colCheckInDate";
            colCheckInDate.ReadOnly = true;
            // 
            // colCheckInTime
            // 
            colCheckInTime.DataPropertyName = "CheckInTime";
            colCheckInTime.HeaderText = "CheckInTime";
            colCheckInTime.MinimumWidth = 8;
            colCheckInTime.Name = "colCheckInTime";
            colCheckInTime.ReadOnly = true;
            // 
            // colNotes
            // 
            colNotes.DataPropertyName = "Notes";
            colNotes.HeaderText = "Notes";
            colNotes.MinimumWidth = 8;
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            // 
            // AttendanceView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(tblAttendance);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "AttendanceView";
            Size = new Size(968, 531);
            Load += AttendanceView_Load;
            tblAttendance.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            flpFilter.ResumeLayout(false);
            flpFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tblAttendance;
        private Panel pnlToolbar;
        private ToolStrip toolStrip;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnView;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton btnRefresh;
        private Panel pnlFilter;
        private FlowLayoutPanel flpFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel pnlGrid;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colMemberName;
        private DataGridViewTextBoxColumn colCheckInDate;
        private DataGridViewTextBoxColumn colCheckInTime;
        private DataGridViewTextBoxColumn colNotes;
    }
}
