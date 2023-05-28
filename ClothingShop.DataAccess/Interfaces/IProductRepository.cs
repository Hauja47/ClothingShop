using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataAccess
{
    using Model;

    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
