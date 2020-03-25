using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model.service
{
    interface IIncomeService
    {
        List<Income> GetAllIncomes();
        void InsertNewIncome(int categoryId, int amount, string note, DateTime date);
        List<ChartData> GetIncomeForChart();
    }
}
