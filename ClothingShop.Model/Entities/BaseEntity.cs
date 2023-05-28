using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public RecordStatus RecordStatus { get; set; }
    }
}
