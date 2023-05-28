using ClothingShop.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Extensions
{

    public static class ProductExtension
    {
        public static ProductDTO ToDTO(this Product entity)
            => new ProductDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Rating = entity.Rating,
                Brand = entity.Brand.ToDTO(),
                Category = entity.Category.ToDTO(),
                Description = entity.Description,
                Variants = entity.Variants.ToList().ToDTO(),
                CreatedDate = entity.CreatedDate,
                RecordStatus = entity.RecordStatus,
                UpdatedDate = entity.UpdatedDate
            };

        public static List<ProductDTO> ToDTO(this List<Product> entities)
            => entities.Select(e => e.ToDTO()).ToList();
    }
}
