using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Data.Models
{
    public class SelectAllIncome
    {
        public int IncomeId { get; set; }
        public string IncomeName { get; set; }
        public decimal IncomeAmount { get; set; }
        public DateTime IncomeDate { get; set; }
    }
}
