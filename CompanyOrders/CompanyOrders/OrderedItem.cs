using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class OrderedItem
    {
        int qty;
        Item item;
        public OrderedItem(Item item, int qty)
        {
            this.item = item;
            this.qty = qty;
        }

        public double getPrice()
        {
            return this.qty * this.item.Rate;
        }
    }
}
