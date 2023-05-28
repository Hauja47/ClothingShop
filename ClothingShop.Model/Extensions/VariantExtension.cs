using ClothingShop.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Extensions
{
    public static class VariantExtension
    {
        public static VariantDTO ToDTO(this Variant entity)
            => new VariantDTO
            {
                Id = entity.Id,
                Attributes = entity.Attributes.ToList().ToDTO(),
                Discount = entity.Discount,
                Images = entity.Images,
                Price = entity.Price,
                ProductId = entity.ProductId,
                Slug = entity.Slug,
                CreatedDate = entity.CreatedDate,
                RecordStatus = entity.RecordStatus,
                UpdatedDate = entity.UpdatedDate,
            };

        public static List<VariantDTO> ToDTO(this List<Variant> entities)
            => entities.Select(e => e.ToDTO()).ToList();
    }
}
