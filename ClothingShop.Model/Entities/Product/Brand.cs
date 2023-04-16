using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
