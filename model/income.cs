using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model
{
    class Income
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IncomeCategoryId { get; set; }
        public string Note { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public Income(int id, int userId, int incomeCategoryId, string note, int amount, DateTime date)
        {
            Id = id;
            UserId = userId;
            IncomeCategoryId = incomeCategoryId;
            Note = note;
            Amount = amount;
            Date = date;
        }
    }
}
