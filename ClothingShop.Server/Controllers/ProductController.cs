using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    using ClothingShop.DataAccess;
    using ClothingShop.Model;
    using ClothingShop.Model.DTO;
    using ClothingShop.Model.Extensions;

    public class ProductController : BaseController
    {
        public ProductController(ShopContext context) : base(context)
        {
        }

        #region Product

        [HttpGet("Product/{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid id)
        {
            try
            {
                var product = await Repo.Product.GetProduct(id);

                if (product == null)
                {
                    return NotFound(new Response
                    {
                        Errors = new List<string>
                        {
                            "Product not found!"
                        }
                    });
                }

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = product.ToDTO()
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new Response
                {
                    Errors = new List<string>
                    {
                        ex.Message, ex.StackTrace
                    }
                });
            }
        }

        [HttpGet("Products")]
        public async Task<IActionResult> GetProducts([FromQuery] int take, [FromQuery] int skip, [FromRoute] Guid id)
        {
            try
            {
                var products = await Repo.Product.GetProducts(take, skip);

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = products.ToDTO()
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new Response
                {
                    Errors = new List<string>
                    {
                        ex.Message, ex.StackTrace
                    }
                });
            }
        }

        #endregion

    }
}
