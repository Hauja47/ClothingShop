using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{
    public class BrandRequest
    {
        public string Name { get; set; }
    }

    public class BrandUpdateRequest : BrandRequest
    {
        public Guid Id { get; set; }
    }

    public class BrandDTO : BaseDTO
    {
        public string Name { get; set; }
    }
}
