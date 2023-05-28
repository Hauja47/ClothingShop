using Microsoft.EntityFrameworkCore;

namespace ClothingShop.DataAccess.Repositories
{
    using ClothingShop.DataAccess.Extensions;
    using Model;

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ShopContext context) : base(context)
        {
        }

        public Task<Product> GetProduct(Guid id, bool tracking = false)
            => this.context.Products
            .Tracking(tracking)
            .Include(p => p.Variants)
                .ThenInclude(v => v.Attributes)
            .FirstOrDefaultAsync(p => p.Id == id);

        public Task<List<Product>> GetProducts(int take, int skip, bool tracking = false)
            => this.context.Products
            .Tracking(tracking)
            .Include(p => p.Variants)
                .ThenInclude(v => v.Attributes)
            .Take(take)
            .Skip(skip)
            .ToListAsync();
    }
}
