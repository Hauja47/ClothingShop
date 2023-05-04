using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public IEnumerable<Product> FavoriteProducts { get; set; }

        public IEnumerable<Promotion> UsedPromotions { get; set; }

        public Guid IdentityId { get; set; }
    }
}
