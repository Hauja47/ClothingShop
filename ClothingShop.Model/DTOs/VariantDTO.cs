using ClothingShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{
    public class VariantRequest
    {
        public Guid ProductId { get; set; }

        public decimal Price { get; set; }

        public decimal? Discount { get; set; }

        public string? Images { get; set; }

        public string Slug { get; set; }

        public List<Guid> AttributeValueIds { get; set; }
    }

    public class VariantUpdateRequest : VariantRequest
    {
        public Guid Id { get; set; }
    }

    public class VariantDTO : BaseDTO
    {
        public Guid ProductId { get; set; }

        public decimal Price { get; set; }

        public decimal? Discount { get; set; }

        public string? Images { get; set; }

        public string Slug { get; set; }

        public List<AttributeValueDTO> Attributes { get; set; }
    }
}
