using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManager.model;
using ExpenseManager.model.service;
using ExpenseManager.model.service.impl;

namespace ExpenseManager.view
{
    public partial class OutcomeHistory : Form
    {
        private static IOutcomeService outcomeService = new OutcomeService();
        private static ICategoryService categoryService = new CategoryService();

        public OutcomeHistory()
        {
            InitializeComponent();
            this.loadTable();
        }

        public void loadTable()
        {
            this.dataGridView1.Refresh();

            if (this.dataGridView1.Columns.Count == 0)
            {
                this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.category,
                    this.note,
                    this.amount,
                    this.date
                });
            }

            List<Outcome> outcomes = outcomeService.GetAllOutcomes();

            foreach (Outcome outcome in outcomes)
            {
                this.dataGridView1.Rows.Add(
                    categoryService.GetOutcomeCategoryById(outcome.OutcomeCategoryId).Name,
                    outcome.Note,
                    outcome.Amount + " MMK",
                    outcome.Date.ToShortDateString()
                );
            }
        }
    }
}
