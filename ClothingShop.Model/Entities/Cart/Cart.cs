using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Entities
{
    public class Cart : BaseEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<CartItem>? Items { get; set;}
    }
}
