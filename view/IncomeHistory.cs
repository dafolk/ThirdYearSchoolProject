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
    public partial class IncomeHistory : Form
    {
        private static IIncomeService incomeService = new IncomeService();
        private static ICategoryService categoryService = new CategoryService();
        public IncomeHistory()
        {
            InitializeComponent();
            this.loadTable();
        }
        public void loadTable()
        {
            this.dataGridView1.Refresh();

            if(this.dataGridView1.Columns.Count == 0)
            {
                this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.category,
                    this.note,
                    this.amount,
                    this.date
                });
            }

            List<Income> incomes = incomeService.GetAllIncomes();

            foreach(Income income in incomes)
            {
                this.dataGridView1.Rows.Add(
                    categoryService.GetIncomeCategoryById(income.IncomeCategoryId).Name,
                    income.Note,
                    income.Amount + " MMK",
                    income.Date.ToShortDateString()
                );
            }
        }
    }
}
