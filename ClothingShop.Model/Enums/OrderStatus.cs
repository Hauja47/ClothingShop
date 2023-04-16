﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public enum OrderStatus
    {
        WaitForConfirmation,
        Confirmed,
        Pending,
        Packaged,
        Shipping,
        Shipped
    }
}
