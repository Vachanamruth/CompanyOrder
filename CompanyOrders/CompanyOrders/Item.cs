using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal class Item
    {
        public string Description { get; private set; }
        public double Rate { get; private set; }
        public Item(double rate, string description) 
        {
            Rate = rate;
            Description = description;
        } 
    }
}
