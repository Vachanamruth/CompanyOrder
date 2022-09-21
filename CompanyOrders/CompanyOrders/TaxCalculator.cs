using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class TaxCalculator
    {
        public static Dictionary<string, ITaxCalculator> Calculators = new Dictionary<string, ITaxCalculator>()
        {
            {"India", new GST()} ,
            {"Abroad", new VAT()}
        };
        public static ITaxCalculator GetCalculator(string country)
        {
            return Calculators[country];
        }
    }
}