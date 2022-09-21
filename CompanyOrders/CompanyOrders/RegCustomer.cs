using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class RegCustomer : Customer
    {
        double splDiscount;
        public RegCustomer(string name, int phoneNumber, double splDiscount) : base(name, phoneNumber) 
        {
            this.splDiscount = splDiscount;
        }
        public double getSplDiscount()
        {
            return this.splDiscount;
        }
        public override double getTotal()
        {
            double total = 0;
            foreach (Order order in this.order)
            {
                if (this.order != null)
                {
                    total += order.getTotal();
                }
                else
                {
                    total += 0;
                }
            }            
            return (total * (1 - this.splDiscount));
        }
    }
}
