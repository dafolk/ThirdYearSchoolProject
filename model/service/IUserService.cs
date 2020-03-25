using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.model.service
{
    interface IUserService
    {
        User GetUserByUsername(string username);
    }
}
