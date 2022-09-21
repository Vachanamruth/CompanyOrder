using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Order
    {
        string country;
        Customer customer;
        List<OrderedItem> orderedItems = new List<OrderedItem>();
        public Order(Customer customer, List<Item> cart, List<int> qty, string country)
        {
            this.country = country;
            this.customer = customer;
            for (int i = 0; i < cart.Count; i++)
            {
                orderedItems.Add(new OrderedItem(cart[i], qty[i]));
            }
        }
        public double getTotal()
        {
            double sum = 0;
            foreach (OrderedItem item in orderedItems)
            {
                sum += item.getPrice();
            }
            ITaxCalculator calculator= TaxCalculator.GetCalculator(this.country);
            double tax = calculator.CalculateTax(sum);
            sum += tax;
            return sum;
        }
    }
}
