using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Attribute : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<AttributeValue> Values { get; set; }
    }
}
