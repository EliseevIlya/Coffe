﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service
{
    internal interface IDiscountService
    {
        double ApplyDiscount(double amount, DateTime time);
    }
}
