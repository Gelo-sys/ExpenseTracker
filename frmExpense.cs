using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class frmExpense : Form
    {
        private readonly Expense expense;
        private static readonly string[] Categories =
            { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" };

        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();
            cboCategory.Items.AddRange(Categories);
            dtpDate.MaxDate = DateTime.Today;           // no future dates

            if (existing == null)
            {
                expense = new Expense();
                Text = "Add Expense";
                cboCategory.SelectedIndex = 0;
                rdoCash.Checked = true;
            }
            else
            {
                expense = existing;
                Text = "Edit Expense";
                dtpDate.Value = existing.Date;
                txtDescription.Text = existing.Description;
                cboCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;
                rdoCash.Checked = existing.PaymentMethod == "Cash";
                rdoGCash.Checked = existing.PaymentMethod == "GCash";
                rdoCard.Checked = existing.PaymentMethod == "Card";
                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;
            }
        }

        public Expense GetExpense() => expense;

        private bool ValidateInputs()
        {
            bool ok = true;
            errProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errProvider.SetError(txtDescription, "Description is required.");
                ok = false;
            }
            if (nudAmount.Value <= 0)
            {
                errProvider.SetError(nudAmount, "Amount must be greater than 0.");
                ok = false;
            }
            return ok;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;
            expense.PaymentMethod = rdoCash.Checked ? "Cash" : rdoGCash.Checked ? "GCash" : "Card";
            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void rdoCard_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}