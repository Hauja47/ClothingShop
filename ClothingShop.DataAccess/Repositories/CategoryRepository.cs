using ClothingShop.DataAccess.Extensions;
using ClothingShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(ShopContext context) : base(context)
        {
        }

        public Task<Category> GetCategory(Guid id, bool tracking = false)
            => this.context.Categories
            .Tracking(tracking)
            .SingleOrDefaultAsync(b => b.Id == id);

        public Task<List<Category>> GetCategories(bool tracking = false)
            => this.context.Categories
            .Tracking(tracking)
            .ToListAsync();

        public Task<Category> GetCategoryByName(string name, bool tracking = false)
            => this.context.Categories
            .Tracking(tracking)
            .SingleOrDefaultAsync(e => e.Name == name);
    }
}
