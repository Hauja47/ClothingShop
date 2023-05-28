using ClothingShop.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Extensions
{
    public static class CategoryExtension
    {
        public static CategoryDTO ToDTO(this Category entity)
           => new CategoryDTO
           {
               Id = entity.Id,
               Name = entity.Name,
               CreatedDate = entity.CreatedDate,
               RecordStatus = entity.RecordStatus,
               UpdatedDate = entity.UpdatedDate,
           };

        public static List<CategoryDTO> ToDTO(this List<Category> entities)
            => entities.Select(e => e.ToDTO()).ToList();
    }
}
