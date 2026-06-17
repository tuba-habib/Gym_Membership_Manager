namespace App.WindowsApp.Forms
{
    partial class MemberPicker
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tblMemberPicker = new TableLayoutPanel();
            flpSearchBar = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlList = new Panel();
            lsMembers = new ListBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            tblMemberPicker.SuspendLayout();
            flpSearchBar.SuspendLayout();
            pnlList.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMemberPicker
            // 
            tblMemberPicker.ColumnCount = 1;
            tblMemberPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMemberPicker.Controls.Add(flpSearchBar, 0, 0);
            tblMemberPicker.Controls.Add(pnlList, 0, 1);
            tblMemberPicker.Controls.Add(flpButtons, 0, 2);
            tblMemberPicker.Dock = DockStyle.Fill;
            tblMemberPicker.Location = new Point(0, 0);
            tblMemberPicker.Name = "tblMemberPicker";
            tblMemberPicker.RowCount = 3;
            tblMemberPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tblMemberPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tblMemberPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tblMemberPicker.Size = new Size(375, 375);
            tblMemberPicker.TabIndex = 0;
            // 
            // flpSearchBar
            // 
            flpSearchBar.BackColor = Color.White;
            flpSearchBar.Controls.Add(lblSearch);
            flpSearchBar.Controls.Add(txtSearch);
            flpSearchBar.Dock = DockStyle.Fill;
            flpSearchBar.Location = new Point(3, 3);
            flpSearchBar.Name = "flpSearchBar";
            flpSearchBar.Size = new Size(369, 39);
            flpSearchBar.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(250, 250, 250);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(83, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(255, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlList
            // 
            pnlList.Controls.Add(lsMembers);
            pnlList.Dock = DockStyle.Fill;
            pnlList.Location = new Point(3, 48);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(369, 256);
            pnlList.TabIndex = 1;
            // 
            // lsMembers
            // 
            lsMembers.BorderStyle = BorderStyle.FixedSingle;
            lsMembers.Dock = DockStyle.Fill;
            lsMembers.Font = new Font("Segoe UI", 10F);
            lsMembers.Location = new Point(0, 0);
            lsMembers.Name = "lsMembers";
            lsMembers.Size = new Size(369, 256);
            lsMembers.TabIndex = 0;
            lsMembers.DoubleClick += lsMembers_DoubleClick;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.White;
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 310);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(369, 62);
            flpButtons.TabIndex = 2;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.LightGray;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.Black;
            btnSelect.Image = Properties.Resources.icon_save;
            btnSelect.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelect.Location = new Point(256, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(110, 34);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextAlign = ContentAlignment.MiddleRight;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(200, 200, 200);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(40, 40, 40);
            btnCancel.Image = Properties.Resources.icon_cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(127, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // MemberPicker
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(375, 375);
            Controls.Add(tblMemberPicker);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemberPicker";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Member";
            tblMemberPicker.ResumeLayout(false);
            flpSearchBar.ResumeLayout(false);
            flpSearchBar.PerformLayout();
            pnlList.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tblMemberPicker;
        private FlowLayoutPanel flpSearchBar;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel pnlList;
        private ListBox lsMembers;
        private FlowLayoutPanel flpButtons;
        private Button btnSelect, btnCancel;
    }
}
