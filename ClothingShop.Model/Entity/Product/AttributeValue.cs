using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class AttributeValue : BaseEntity
    {
        public Guid AttributeId { get; set; }
        
        public Guid VariantId { get; set; }

        public string Value { get; set; }

        public Variant Variant { get; set; }

        public Attribute Attribute { get; set; }
    }
}
