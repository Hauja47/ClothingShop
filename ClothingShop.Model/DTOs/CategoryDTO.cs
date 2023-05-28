using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{
    public class CategoryRequest
    {
        public string Name { get; set; }
    }

    public class CategoryUpdateRequest : CategoryRequest
    {
        public Guid Id { get; set; }
    }

    public class CategoryDTO : BaseDTO
    {
        public string Name { get; set; }
    }
}
