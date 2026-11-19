namespace ExpenseTracker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tbsEdit = new ToolStripButton();
            tbsDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tbsSave = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCount = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            pnlFilter = new Panel();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            chkDateRange = new CheckBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            pnlSummary = new Panel();
            lblRemaining = new Label();
            lblShown = new Label();
            lblBudget = new Label();
            nudBudget = new NumericUpDown();
            dgvExpenses = new DataGridView();
            tmrClock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, newToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.N;
            fileToolStripMenuItem1.Size = new Size(180, 22);
            fileToolStripMenuItem1.Text = "&New";
            fileToolStripMenuItem1.Click += New_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&Open...";
            newToolStripMenuItem.Click += Open_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += Save_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += Exit_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            expenseToolStripMenuItem.Size = new Size(62, 20);
            expenseToolStripMenuItem.Text = "&Expense";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += Add_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += Edit_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += Delete_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += About_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tbsEdit, tbsDelete, toolStripSeparator1, tbsSave });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(33, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += Add_Click;
            // 
            // tbsEdit
            // 
            tbsEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsEdit.Image = (Image)resources.GetObject("tbsEdit.Image");
            tbsEdit.ImageTransparentColor = Color.Magenta;
            tbsEdit.Name = "tbsEdit";
            tbsEdit.Size = new Size(31, 22);
            tbsEdit.Text = "Edit";
            tbsEdit.Click += Edit_Click;
            // 
            // tbsDelete
            // 
            tbsDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsDelete.Image = (Image)resources.GetObject("tbsDelete.Image");
            tbsDelete.ImageTransparentColor = Color.Magenta;
            tbsDelete.Name = "tbsDelete";
            tbsDelete.Size = new Size(44, 22);
            tbsDelete.Text = "Delete";
            tbsDelete.Click += Delete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tbsSave
            // 
            tbsSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbsSave.Image = (Image)resources.GetObject("tbsSave.Image");
            tbsSave.ImageTransparentColor = Color.Magenta;
            tbsSave.Name = "tbsSave";
            tbsSave.Size = new Size(35, 22);
            tbsSave.Text = "Save";
            tbsSave.Click += Save_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblCount, lblClock });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(884, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(811, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(58, 17);
            lblCount.Text = "0 Records";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(0, 17);
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(chkDateRange);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(cboCategory);
            pnlFilter.Controls.Add(lblCategory);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 49);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(0, 15, 0, 15);
            pnlFilter.Size = new Size(884, 45);
            pnlFilter.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(651, 15);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(18, 15);
            lblTo.TabIndex = 0;
            lblTo.Text = "to";
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(676, 11);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(195, 23);
            dtpTo.TabIndex = 0;
            dtpTo.ValueChanged += Filter_Changed;
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(449, 11);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(195, 23);
            dtpFrom.TabIndex = 6;
            dtpFrom.ValueChanged += Filter_Changed;
            // 
            // chkDateRange
            // 
            chkDateRange.AutoSize = true;
            chkDateRange.Location = new Point(357, 13);
            chkDateRange.Name = "chkDateRange";
            chkDateRange.Size = new Size(86, 19);
            chkDateRange.TabIndex = 4;
            chkDateRange.Text = "Date Range";
            chkDateRange.UseVisualStyleBackColor = true;
            chkDateRange.CheckedChanged += chkDateRange_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(251, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(200, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(73, 11);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 4;
            cboCategory.SelectedIndexChanged += Filter_Changed;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // pnlSummary
            // 
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Controls.Add(lblShown);
            pnlSummary.Controls.Add(lblBudget);
            pnlSummary.Controls.Add(nudBudget);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 489);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Padding = new Padding(15, 0, 15, 0);
            pnlSummary.Size = new Size(884, 50);
            pnlSummary.TabIndex = 7;
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemaining.Location = new Point(390, 18);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(185, 15);
            lblRemaining.TabIndex = 8;
            lblRemaining.Text = "Remaining this month: PHP 0.00";
            // 
            // lblShown
            // 
            lblShown.AutoSize = true;
            lblShown.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShown.Location = new Point(12, 18);
            lblShown.Name = "lblShown";
            lblShown.Size = new Size(144, 15);
            lblShown.TabIndex = 0;
            lblShown.Text = "Shown: 0 Total: PHP 0.00";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(162, 18);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(96, 15);
            lblBudget.TabIndex = 1;
            lblBudget.Text = "Monthly budget:";
            // 
            // nudBudget
            // 
            nudBudget.DecimalPlaces = 2;
            nudBudget.Location = new Point(264, 14);
            nudBudget.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(120, 23);
            nudBudget.TabIndex = 2;
            nudBudget.ThousandsSeparator = true;
            nudBudget.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            nudBudget.ValueChanged += nudBudget_ValueChanged;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.Location = new Point(0, 94);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(884, 395);
            dgvExpenses.TabIndex = 8;
            dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dgvExpenses);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tbsEdit;
        private ToolStripButton tbsDelete;
        private ToolStripButton tbsSave;
        private ToolStripSeparator toolStripSeparator1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblCount;
        private ToolStripStatusLabel lblClock;
        private Panel pnlFilter;
        private Label lblCategory;
        private ComboBox cboCategory;
        private TextBox txtSearch;
        private Label lblSearch;
        private CheckBox chkDateRange;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Panel pnlSummary;
        private Label lblRemaining;
        private NumericUpDown nudBudget;
        private Label lblBudget;
        private Label lblShown;
        private DataGridView dgvExpenses;
        private System.Windows.Forms.Timer tmrClock;
    }
}
