using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company.items["Pens"] = new Item(10, "Pens");
            Company.items["Eraser"] = new Item(5, "Eraser");
            Company.items["Paper"] = new Item(1, "Paper");
            Company.items["Notebook"]  = new Item(50, "Notebook");
            Company abc = new Company();
            Customer customer1 = new Customer("a", 7897897987);
            abc.addCustomer(customer1);
            customer1.addToCart(Company.items["Pens"], 5);
            customer1.addToCart(Company.items["Eraser"], 2);
            customer1.addToCart(Company.items["Paper"], 100);
            customer1.addToCart(Company.items["Notebook"], 4);
            customer1.checkOut();
            Console.WriteLine(abc.getTotalWorthOfOrdersPlaced());
        }
    }
}
