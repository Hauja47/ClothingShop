using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Cart : BaseEntity
    {
        public Guid UserId { get; set; }

        //public Person Person { get; set; }
        public ApplicationUser User { get; set; }

        public IEnumerable<CartItem>? Items { get; set;}
    }
}
