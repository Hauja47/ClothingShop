             using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Comment : BaseEntity
    {
        public Guid UserId { get; set; }

        public string Content { get; set; }

        public string? Images { get; set; }

        public decimal Rating { get; set; }

        public int Like { get; set; }

        public int Dislike { get; set; }

        public Guid? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Comment? ParentComment { get; set; }

        public ApplicationUser User { get; set; }
    }
}
