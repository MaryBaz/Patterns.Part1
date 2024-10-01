using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Part1
{
    public interface IAccountInterest
    {
        public double CalculateInterest(Account account);
    }
}
