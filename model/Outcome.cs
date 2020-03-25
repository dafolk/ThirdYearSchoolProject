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
        public int OutcomeCategoryId { get; set; }
        public string Note { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public Outcome(int id, int userId, int outcomeCategoryId, string note, int amount, DateTime date)
        {
            Id = id;
            UserId = userId;
            OutcomeCategoryId = outcomeCategoryId;
            Note = note;
            Amount = amount;
            Date = date;
        }
    }
}
