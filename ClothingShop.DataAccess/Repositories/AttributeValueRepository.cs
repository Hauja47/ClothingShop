using ClothingShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataAccess.Repositories
{
    public class AttributeValueRepository : GenericRepository<AttributeValue>
    {
        public AttributeValueRepository(ShopContext context) : base(context)
        {
        }
    }
}
