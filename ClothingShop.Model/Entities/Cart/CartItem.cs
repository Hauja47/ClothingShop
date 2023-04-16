﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Entities
{
    public class CartItem : BaseEntity
    {
        public int Quantity { get; set; }

        public Guid VariantId { get; set; }

        public Variant Variant { get; set; }
    }
}
