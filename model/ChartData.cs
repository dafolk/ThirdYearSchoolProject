using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model
{
    class ChartData
    {
        public int CategoryId { get; set; }
        public int Amount { get; set; }

        public ChartData(int categoryId, int amount)
        {
            CategoryId = categoryId;
            Amount = amount;
        }
    }
}
