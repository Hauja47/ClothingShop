using ClothingShop.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Extensions
{


    public static class AttributeExtension
    {
        public static AttributeDTO ToDTO(this Attribute entity)
            => new AttributeDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                CreatedDate = entity.CreatedDate,
                RecordStatus = entity.RecordStatus,
                UpdatedDate = entity.UpdatedDate
            };

        public static List<AttributeDTO> ToDTO(this List<Attribute> entities)
            => entities.Select(e => e.ToDTO()).ToList();
    }
}
