using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class VAT : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            return 0.025 * amount;
        }
    }
}
