using ClothingShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Variant : BaseEntity
    {
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public decimal Price { get; set; }

        public decimal? Discount { get; set; }

        public string? Images { get; set; }

        public string Slug { get; set; }

        public Status Status { get; set; }

        public IEnumerable<AttributeValue> Attributes { get; set; }
    }
}
