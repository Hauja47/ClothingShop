using ClothingShop.DataAccess;
using ClothingShop.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    public class BaseController : ControllerBase
    {
        private ShopContext context;

        protected Repositories Repo => this.repo ??= new Repositories(context);
        private Repositories repo;

        public BaseController(ShopContext context) { this.context = context; }
    }
}
