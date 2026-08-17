using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_and_Taxes
{
    public class IncomeEntry
    {
        public string Source { get; set; }
        public decimal Amount { get; set; }

        public IncomeEntry(string source, decimal amount)
        {
            Source = source;
            Amount = amount;
        }
    }
}
