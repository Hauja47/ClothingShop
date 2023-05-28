using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{
    public class ProductRequest
    {
        public string Name { get; set; }

        public Guid BrandId { get; set; }

        public Guid CategoryId { get; set; }

        public decimal? Rating { get; set; }

        public string? Description { get; set; }
    }

    public class ProductUpdateRequest : ProductRequest
    {
        public Guid Id { get; set; }
    }

    public class ProductDTO : BaseDTO
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public BrandDTO Brand { get; set; }

        public CategoryDTO Category { get; set; }

        public decimal? Rating { get; set; }

        public List<VariantDTO> Variants { get; set; }
    }
}
