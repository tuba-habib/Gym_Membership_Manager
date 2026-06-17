namespace App.WindowsApp.Views
{
    partial class TrainersView
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
            tblTrainers = new TableLayoutPanel();
            pnlToolbar = new Panel();
            toolStrip = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilter = new Panel();
            flpFilter = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlGrid = new Panel();
            dgvTrainers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colSpecialization = new DataGridViewTextBoxColumn();
            tblTrainers.SuspendLayout();
            pnlToolbar.SuspendLayout();
            toolStrip.SuspendLayout();
            pnlFilter.SuspendLayout();
            flpFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            SuspendLayout();
            // 
            // tblTrainers
            // 
            tblTrainers.ColumnCount = 1;
            tblTrainers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblTrainers.Controls.Add(pnlToolbar, 0, 0);
            tblTrainers.Controls.Add(pnlFilter, 0, 1);
            tblTrainers.Controls.Add(pnlGrid, 0, 2);
            tblTrainers.Dock = DockStyle.Fill;
            tblTrainers.Location = new Point(0, 0);
            tblTrainers.Name = "tblTrainers";
            tblTrainers.RowCount = 3;
            tblTrainers.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblTrainers.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblTrainers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTrainers.Size = new Size(875, 590);
            tblTrainers.TabIndex = 0;
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
            flpFilter.Controls.Add(lblSearch);
            flpFilter.Controls.Add(txtSearch);
            flpFilter.Dock = DockStyle.Fill;
            flpFilter.Location = new Point(6, 6);
            flpFilter.Name = "flpFilter";
            flpFilter.Size = new Size(853, 43);
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
            pnlGrid.Controls.Add(dgvTrainers);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 108);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(869, 479);
            pnlGrid.TabIndex = 2;
            // 
            // dgvTrainers
            // 
            dgvTrainers.AllowUserToAddRows = false;
            dgvTrainers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dgvTrainers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainers.BackgroundColor = Color.White;
            dgvTrainers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colSpecialization });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTrainers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTrainers.Dock = DockStyle.Fill;
            dgvTrainers.EnableHeadersVisualStyles = false;
            dgvTrainers.GridColor = Color.FromArgb(220, 220, 220);
            dgvTrainers.Location = new Point(0, 0);
            dgvTrainers.Margin = new Padding(4);
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.ReadOnly = true;
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.RowHeadersWidth = 62;
            dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new Size(869, 479);
            dgvTrainers.TabIndex = 0;
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
            // colSpecialization
            // 
            colSpecialization.DataPropertyName = "Specialization";
            colSpecialization.HeaderText = "Specialization";
            colSpecialization.MinimumWidth = 8;
            colSpecialization.Name = "colSpecialization";
            colSpecialization.ReadOnly = true;
            // 
            // TrainersView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(tblTrainers);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "TrainersView";
            Size = new Size(875, 590);
            tblTrainers.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            pnlFilter.ResumeLayout(false);
            flpFilter.ResumeLayout(false);
            flpFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tblTrainers;
        private Panel pnlToolbar;
        private ToolStrip toolStrip;
        private ToolStripButton tsbAdd, tsbEdit, tsbView, tsbDelete, tsbRefresh;
        private ToolStripSeparator toolStripSeparator1;
        private Panel pnlFilter;
        private FlowLayoutPanel flpFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel pnlGrid;
        private DataGridView dgvTrainers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSpecialization;
    }
}
