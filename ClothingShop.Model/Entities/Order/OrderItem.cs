using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderId { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        public decimal Balance { get; set; }

        public Order Order { get; set; }
    }
}
