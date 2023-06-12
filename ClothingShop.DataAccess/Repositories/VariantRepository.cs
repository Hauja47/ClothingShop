using ClothingShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataAccess.Repositories
{
    public class VariantRepository : GenericRepository<Variant>
    {
        public VariantRepository(ShopContext context) : base(context)
        {
        }
    }
}
