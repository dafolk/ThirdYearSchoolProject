using ExpenseManager.model;
using ExpenseManager.model.service;
using ExpenseManager.model.service.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.view
{
    public partial class NewOutcome : Form
    {
        private ICategoryService categoryService = new CategoryService();
        private IOutcomeService outcomeService = new OutcomeService();

        public NewOutcome()
        {
            InitializeComponent();
            this.loadComboBox();
        }

        private void loadComboBox()
        {
            List<OutcomeCategory> outcomeCategories = categoryService.GetAllOutcomeCategories();

            foreach (OutcomeCategory outcomeCategory in outcomeCategories)
            {
                this.cmbCategory.Items.Add(outcomeCategory.Name);
            }

            this.cmbCategory.SelectedIndex = 0;
        }

        private void save()
        {
            int categoryId = categoryService.GetOutcomeCategoryByName(
                this.cmbCategory
                .SelectedItem
                .ToString()
            ).Id;

            int amount = int.Parse(this.txtAmount.Text);

            string note = this.txtNote.Text;

            DateTime date = DateTime.ParseExact(
                dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                "yyyy-MM-dd",
                null
            );

            this.cmbCategory.SelectedIndex = 0;


            this.outcomeService.InsertNewOutcome(categoryId, amount, note, date);
        }

        private void clean()
        {
            this.cmbCategory.SelectedIndex = 0;
            this.txtAmount.Text = "";
            this.txtNote.Text = "";
            this.dateTimePicker1.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save();
            this.clean();
            MessageBox.Show(
                "Your new income is saved",
                "Saved new income",
                MessageBoxButtons.OK
            );
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clean();
        }
    }
}
