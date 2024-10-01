using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Part1
{
    public class SalaryProjectAccount : IAccountInterest
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.5;
        }
    }
}
