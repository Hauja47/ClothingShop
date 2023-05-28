using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataAccess.Repositories
{
    public class Repositories
    {
        public ProductRepository Product => this.product ??= new ProductRepository(context);
        private ProductRepository product;

        public BrandRepository Brand => this.brand ??= new BrandRepository(context);
        private BrandRepository brand;

        public CategoryRepository Category => this.category ??= new CategoryRepository(context);
        private CategoryRepository category;

        public AttributeRepository Attribute => this.attribute ??= new AttributeRepository(context);
        private AttributeRepository attribute;


        private ShopContext context;

        public Repositories(ShopContext context)
        {
            this.context = context;
        }
    }
}
