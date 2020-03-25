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
    public partial class Home : Form
    {
        IIncomeService incomeService = new IncomeService();
        IOutcomeService outcomeService = new OutcomeService();
        ICategoryService categoryService = new CategoryService();

        public Home()
        {
            InitializeComponent();
            this.loadIncomeData();
            this.loadOutcomeData();
        }

        private void loadIncomeData()
        {
            int totalIncome = 0;
            List<ChartData> chartIncomeData = incomeService.GetIncomeForChart();

            for(int i=0; i< chartIncomeData.Count; i++)
            {
                chartIncome.Series[0].Points.AddXY(
                    categoryService.GetIncomeCategoryById(chartIncomeData.ElementAt(i).CategoryId).Name,
                    chartIncomeData.ElementAt(i).Amount
                );
                totalIncome += chartIncomeData.ElementAt(i).Amount;
            }
            this.lblIncome.Text = totalIncome + " Kyats";
        }

        private void loadOutcomeData()
        {
            int totalOutcome = 0;
            List<ChartData> chartOutcomeData = outcomeService.GetOutcomeForChart();

            for (int i = 0; i < chartOutcomeData.Count; i++)
            {
                chartOutcome.Series[0].Points.AddXY(
                    categoryService.GetOutcomeCategoryById(chartOutcomeData.ElementAt(i).CategoryId).Name,
                    chartOutcomeData.ElementAt(i).Amount
                );
                totalOutcome += chartOutcomeData.ElementAt(i).Amount;
            }

            this.lblOutcome.Text = totalOutcome + " Kyats";
        }
    }
}
