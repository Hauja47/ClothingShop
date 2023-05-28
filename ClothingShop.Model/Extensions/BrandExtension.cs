using ClothingShop.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Extensions
{
    public static class BrandExtension
    {
        public static BrandDTO ToDTO(this Brand entity)
            => new BrandDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                CreatedDate = entity.CreatedDate,
                RecordStatus = entity.RecordStatus,
                UpdatedDate = entity.UpdatedDate
            };

        public static List<BrandDTO> ToDTO(this List<Brand> entities)
            => entities.Select(e => e.ToDTO()).ToList();
    }
}
