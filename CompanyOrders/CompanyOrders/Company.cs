using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Company
    {
        List<Customer> customers = new List<Customer>();
        public static Dictionary<string, Item> items = new Dictionary<string, Item>();
        public Company() { }
        public void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void removeCustomer(Customer customer)
        {
            if (this.customers.Contains(customer))
            {
                customers.Remove(customer);
            }
        }
        public List<Customer> GetCustomers()
        {
            return this.customers;
        }
        public static void addItem(Item item)
        {
            items[item.Description] = item;
        }
        public static void removeItem(Item item)
        {
            if (items.ContainsKey(item.Description))
            {
                items.Remove(item.Description);
            }
        }
        public double getTotalWorthOfOrdersPlaced()
        {
            double sum = 0;
            foreach (Customer customer in customers)
            {
                sum += customer.getTotal();
            }
            return sum;
        }
    }
}
