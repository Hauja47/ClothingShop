using ClothingShop.DataAccess.Extensions;
using ClothingShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothingShop.DataAccess.Repositories
{
    public class BrandRepository : GenericRepository<Brand>
    {
        public BrandRepository(ShopContext context) : base(context)
        {
        }

        public Task<Brand> GetBrand(Guid id, bool tracking = false)
            => this.context.Brands
            .Tracking(tracking)
            .SingleOrDefaultAsync(b => b.Id == id);

        public Task<List<Brand>> GetBrands(bool tracking = false)
            => this.context.Brands
            .Tracking(tracking)
            .ToListAsync();

        public Task<Brand> GetBrandByName(string name, bool tracking = false)
            => this.context.Brands
            .Tracking(tracking)
            .SingleOrDefaultAsync(e => e.Name == name);
    }
}
