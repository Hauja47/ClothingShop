using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{
    public class AttributeValueRequest
    {
        public Guid AttributeId { get; set; }

        public string Value { get; set; }
    }

    public class AttributeValueUpdateRequest
    {
        public Guid Id { get; set; }
    }

    public class AttributeValueDTO : BaseDTO
    {
        public AttributeDTO Attribute { get; set; }

        public string Value { get; set; }
    }
}
