using ExpenseManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManager.model.service;
using ExpenseManager.model.service.impl;

namespace ExpenseManager.view
{
    public partial class NewIncome : Form
    {
        private ICategoryService categoryService = new CategoryService();
        private IIncomeService incomeService = new IncomeService();
        public NewIncome()
        {
            InitializeComponent();
            this.loadComboBox();
        }

        private void loadComboBox()
        {
            List<IncomeCategory> incomeCategories = categoryService.GetAllIncomeCategories();

            foreach(IncomeCategory incomeCategory in incomeCategories)
            {
                this.cmbCategory.Items.Add(incomeCategory.Name);
            }

            this.cmbCategory.SelectedIndex = 0;
        }

        private void save()
        {
            int categoryId = categoryService.GetIncomeCategoryByName(
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

            this.incomeService.InsertNewIncome(categoryId, amount, note, date);
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
