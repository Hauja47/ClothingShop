using ClothingShop.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.Extensions
{


    public static class AttributeValueExtension
    {
        public static AttributeValueDTO ToDTO(this AttributeValue entity)
            => new AttributeValueDTO
            {
                Id = entity.Id,
                Value = entity.Value,
                Attribute = entity.Attribute.ToDTO(),
                CreatedDate = entity.CreatedDate,
                RecordStatus = entity.RecordStatus,
                UpdatedDate = entity.UpdatedDate
            };

        public static List<AttributeValueDTO> ToDTO(this List<AttributeValue> entities)
            => entities.Select(e => e.ToDTO()).ToList();
    }
}
