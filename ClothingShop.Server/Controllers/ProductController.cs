using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    using ClothingShop.DataAccess;
    using ClothingShop.Model;
    using ClothingShop.Model.DTO;
    using ClothingShop.Model.Extensions;
    using static Confluent.Kafka.ConfigPropertyNames;

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

        [HttpPost("Products")]
        public async Task<IActionResult> AddProduct([FromBody] ProductRequest request)
        {
            try
            {
                var category = await Repo.Category.GetCategory(request.CategoryId);

                if (category == null)
                {
                    return NotFound(new Response
                    {
                        Errors = new List<string>
                        {
                            "Không tìm thấy Danh mục!"
                        }
                    });
                }

                var brand = await Repo.Brand.GetBrand(request.BrandId);

                if (brand == null)
                {
                    return NotFound(new Response
                    {
                        Errors = new List<string>
                        {
                            "Không tìm thấy Thương hiệu!"
                        }
                    });
                }

                var product = new Product
                {
                    Name = request.Name,
                    Brand = brand,
                    Category = category,
                    Description = request.Description,
                    Rating = 0,
                };

                var variants = new List<Variant>();
                foreach (var variantRequest in request.Variants)
                {
                    var variant = new Variant
                    {
                        Images = variantRequest.Images,
                        Discount = variantRequest.Discount,
                        Price = variantRequest.Price,
                        Product = product,
                        Slug = variantRequest.Slug,
                    };

                    var attributeValues = new List<AttributeValue>();
                    foreach (var attributeValue in variantRequest.AttributeValues)
                    {
                        var attribute = await Repo.Attribute.GetAttribute(attributeValue.AttributeId);

                        if (attribute == null)
                        {
                            return NotFound(new Response
                            {
                                Errors = new List<string>
                                {
                                    "Không tìm thấy Thuộc tính!"
                                }
                            });
                        }

                        attributeValues.Add(new AttributeValue
                        {
                            Attribute = attribute,
                            Value = attributeValue.Value,
                            Variant = variant
                        });
                    }

                    variant.Attributes = attributeValues;

                    this.Repo.Variant.Add(variant);

                    variants.Add(variant);
                }

                product.Variants = variants;

                this.Repo.Product.Add(product);

                await this.Repo.SaveChanges();

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

        #endregion

    }
}
