using ClothingShop.DataAccess.Extensions;
using ClothingShop.Model;
using Microsoft.EntityFrameworkCore;

namespace ClothingShop.DataAccess.Repositories
{
    public class AttributeRepository : GenericRepository<Model.Attribute>
    {
        public AttributeRepository(ShopContext context) : base(context)
        {
        }

        public Task<Model.Attribute> GetAttribute(Guid id, bool tracking = false)
             => this.context.Attributes
            .Tracking(tracking)
            .SingleOrDefaultAsync(b => b.Id == id);

        public Task<List<Model.Attribute>> GetAttributes(bool tracking = false)
            => this.context.Attributes
            .Tracking(tracking)
            .ToListAsync();

        public Task<Model.Attribute> GetAttributeByName(string name, bool tracking = false)
            => this.context.Attributes
            .Tracking(tracking)
            .SingleOrDefaultAsync(e => e.Name == name);
    }
}
