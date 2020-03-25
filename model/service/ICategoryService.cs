using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpenseManager.model;

namespace ExpenseManager.model.service
{
    interface ICategoryService
    {
        IncomeCategory GetIncomeCategoryById(int id);
        IncomeCategory GetIncomeCategoryByName(string name);
        List<IncomeCategory> GetAllIncomeCategories();

        OutcomeCategory GetOutcomeCategoryById(int id);
        OutcomeCategory GetOutcomeCategoryByName(string name);
        List<OutcomeCategory> GetAllOutcomeCategories();
    }
}
