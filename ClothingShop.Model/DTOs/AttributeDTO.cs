using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{
    public class AttributeRequest
    {
        public string Name { get; set; }
    }

    public class AttributeUpdateRequest : AttributeRequest
    {
        public Guid Id { get; set; }
    }

    public class AttributeDTO : BaseDTO
    {
        public string Name { get; set; }
    }
}
