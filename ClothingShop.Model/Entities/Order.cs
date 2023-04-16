using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public  class Order
    {
        public string Address { get; set; }

        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        public decimal Balance { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public Guid UserId { get; set; }

        public Guid? PromotionId { get; set; }

        public User User { get; set; }

        public Promotion Promotion { get; set; }
    }
}
