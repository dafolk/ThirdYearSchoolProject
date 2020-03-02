using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model
{
    class Outcome
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IncomeCategoryId { get; set; }
        public string Note { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
