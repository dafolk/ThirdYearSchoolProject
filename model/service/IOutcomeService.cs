using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model.service
{
    interface IOutcomeService
    {
        List<Outcome> GetAllOutcomes();
        void InsertNewOutcome(int categoryId, int amount, string note, DateTime date);
        List<ChartData> GetOutcomeForChart();
    }
}
