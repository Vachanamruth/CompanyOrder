﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrders
{
    internal interface ITaxCalculator
    {
        double CalculateTax(double amount);
    }
}
