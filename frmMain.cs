using System.Text.Json;

namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        // ===== Fields =====
        private readonly List<Expense> expenses = new List<Expense>();
        private string? currentFile = null;
        private bool isDirty = false;

        public frmMain()
        {
            InitializeComponent();
        }

        // ===== Load =====
        private void frmMain_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Add("All");
            cboCategory.Items.AddRange(new string[]
                { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboCategory.SelectedIndex = 0;

            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;

            UpdateClock();
            UpdateTitle();
            ApplyFilter();
        }

        // ===== Filter =====
        private void ApplyFilter()
        {
            IEnumerable<Expense> query = expenses;

            if (cboCategory.Text != "All")
                query = query.Where(x => x.Category == cboCategory.Text);

            string keyword = txtSearch.Text.Trim().ToLower();
            if (keyword != "")
                query = query.Where(x => x.Description.ToLower().Contains(keyword));

            if (chkDateRange.Checked)
                query = query.Where(x => x.Date.Date >= dtpFrom.Value.Date &&
                                         x.Date.Date <= dtpTo.Value.Date);

            List<Expense> shown = query.OrderByDescending(x => x.Date).ToList();
            dgvExpenses.DataSource = shown;

            // Grid formatting
            dgvExpenses.Columns["Id"].Visible = false;
            dgvExpenses.Columns["Notes"].Visible = false;
            dgvExpenses.Columns["Date"].DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvExpenses.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dgvExpenses.Columns["Amount"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            lblShown.Text = $"Shown: {shown.Count}   Total: PHP {shown.Sum(x => x.Amount):N2}";
            lblCount.Text = $"{expenses.Count} records";
            UpdateBudget();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = chkDateRange.Checked;
            ApplyFilter();
        }

        // ===== Budget, clock, title =====
        private void UpdateBudget()
        {
            decimal spent = expenses
                .Where(x => x.Date.Year == DateTime.Today.Year && x.Date.Month == DateTime.Today.Month)
                .Sum(x => x.Amount);
            decimal remaining = nudBudget.Value - spent;

            lblRemaining.Text = $"Remaining this month: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.Green;
        }

        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            UpdateBudget();
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateTitle()
        {
            string name = currentFile == null ? "Untitled" : Path.GetFileName(currentFile);
            Text = $"Expense Tracker - {name}{(isDirty ? "*" : "")}";
        }

        private void SetDirty(bool value)
        {
            isDirty = value;
            UpdateTitle();
        }

        // ===== Add / Edit / Delete =====
        private void Add_Click(object sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                Expense item = form.GetExpense();
                item.Id = expenses.Count > 0 ? expenses.Max(x => x.Id) + 1 : 1;
                expenses.Add(item);
                SetDirty(true);
                ApplyFilter();
                lblStatus.Text = "Expense added.";
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow == null)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }
            Expense selected = (Expense)dgvExpenses.CurrentRow.DataBoundItem;
            using (frmExpense form = new frmExpense(selected))
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;
                SetDirty(true);
                ApplyFilter();
                lblStatus.Text = "Expense updated.";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow == null)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }
            Expense selected = (Expense)dgvExpenses.CurrentRow.DataBoundItem;
            DialogResult answer = MessageBox.Show($"Delete \"{selected.Description}\"?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes) return;

            expenses.Remove(selected);
            SetDirty(true);
            ApplyFilter();
            lblStatus.Text = "Expense deleted.";
        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Edit_Click(sender, e);
        }

        // ===== Save / Open / New =====
        private bool SaveFile(bool saveAs)
        {
            string? path = currentFile;

            if (saveAs || path == null)
            {
                using SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                dialog.FileName = "expenses.json";
                if (dialog.ShowDialog() != DialogResult.OK) return false;
                path = dialog.FileName;
            }

            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(path, JsonSerializer.Serialize(expenses, options));
                currentFile = path;
                SetDirty(false);
                lblStatus.Text = "File saved.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // true = OK to continue, false = user chose Cancel (or save failed)
        private bool ConfirmDiscard()
        {
            if (!isDirty) return true;

            DialogResult answer = MessageBox.Show(
                "You have unsaved changes. Save them first?", "Unsaved Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel) return false;
            if (answer == DialogResult.Yes) return SaveFile(false);
            return true; // No = discard
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscard()) return;
            expenses.Clear();
            currentFile = null;
            SetDirty(false);
            ApplyFilter();
            lblStatus.Text = "New file.";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscard()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);

                expenses.Clear();
                if (loaded != null) expenses.AddRange(loaded);

                currentFile = dialog.FileName;
                SetDirty(false);
                ApplyFilter();
                lblStatus.Text = "File opened.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFile(false);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ConfirmDiscard()) e.Cancel = true;
        }

        // ===== About =====
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Expense Tracker v1.0\nDeveloper: Estanislao, Mark Angelo", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
