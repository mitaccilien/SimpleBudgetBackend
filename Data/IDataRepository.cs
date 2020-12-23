using System;
using System.Collections.Generic;
using SimpleBudget.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Data
{
    public interface IDataRepository
    {
        IEnumerable<SelectAllIncome> GetIncomes();
        SelectAnIncome GetIncome(int incomeId);
        
    }
}
