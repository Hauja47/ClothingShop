using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class Promotion : BaseEntity
    {
        public string Code { get; set; }

        public string Condition { get; set; }

        public decimal? DiscountValue { get; set; }

        public decimal? DiscountPercent { get; set; }

        public long Quantity { get; set; }

        public DateTime ExpiredDate { get; set; }

        public bool IsPublished { get; set; }

        public Guid? UserId { get; set; }

        //public virtual IEnumerable<Guid> UsedUserId { get; set; }


        public Person? Person;

        public IEnumerable<Person> UsedPersons { get; set; }
    }
}
