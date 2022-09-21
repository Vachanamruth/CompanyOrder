using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Customer
    {
        List<Item> cart = new List<Item>();
        List<int> qty = new List<int>();
        protected List<Order> order = new List<Order>();
        string name;
        bool regCustomer = false;
        double splDiscount = 0;
        double phoneNumber;
        public Customer(string name, double phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public void addToCart(Item item, int qty)
        {
            if (Company.items.ContainsKey(item.Description))
            {
                if (!this.cart.Contains(item))
                {
                    this.cart.Add(item);
                    this.qty.Add(qty);
                }
                else
                {
                    this.qty[this.cart.IndexOf(item)] += qty;
                }
            }
        }
        public void removeFromCart(Item item ,int qty)
        {
            if (this.cart.Contains(item))
            {
                if (qty < this.qty[this.cart.IndexOf(item)])
                {
                    this.qty[this.cart.IndexOf(item)] -= qty;
                }
                else
                {
                    this.qty.RemoveAt(this.cart.IndexOf(item));
                    this.cart.Remove(item);
                }
            }
        }
        public void checkOut()
        {
            Console.WriteLine("Enter your location (India/Abroad)");
            string country = Console.ReadLine();
            this.order.Add(new Order(this, this.cart, this.qty, country));
            this.cart.Clear();
            this.qty.Clear();
        }
        public void register(double splDiscount)
        {
            regCustomer = true;
            this.splDiscount = splDiscount;
        }
        public virtual double getTotal()
        {            
            if(this.order != null && this.regCustomer == true)
            {
                double total = 0;
                foreach(Order order in this.order)
                {
                    total += order.getTotal() * (1 - this.splDiscount);
                }
                return total;
            }
            else if(this.order != null)
            {
                double total = 0;
                foreach (Order order in this.order)
                {
                    total = order.getTotal();
                }
                return total;
            }
            else
            {
                return 0;
            }
        }
    }
}