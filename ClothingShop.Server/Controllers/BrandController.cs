using ClothingShop.DataAccess;
using ClothingShop.Model.DTO;
using ClothingShop.Model.Extensions;
using ClothingShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    public class BrandController : BaseController
    {
        public BrandController(ShopContext context) : base(context)
        {
        }


        #region Brand

        [HttpPost("Brands")]
        public async Task<IActionResult> AddBrand([FromBody] BrandRequest request)
        {
            try
            {
                var obj = await Repo.Brand.GetBrandByName(request.Name);

                if (obj != null && obj.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return BadRequest(new Response
                    {
                        Errors = new List<string>
                        {
                            $"Thương hiệu {request.Name} đã tồn tại!"
                        }
                    });
                }

                var brand = new Brand
                {
                    Name = request.Name
                };

                this.Repo.Brand.Add(brand);

                await this.Repo.Brand.SaveChanges();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = brand.ToDTO()
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

        [HttpGet("Brands")]
        public async Task<IActionResult> GetBrands()
        {
            try
            {
                var brands = await this.Repo.Brand.GetBrands();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = brands.ToDTO()
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

        [HttpGet("Brand/{id}")]
        public async Task<IActionResult> GetBrand([FromRoute] Guid id)
        {
            try
            {
                var brand = await Repo.Brand.GetBrand(id);

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

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = brand.ToDTO()
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

        [HttpPatch("Brand")]
        public async Task<IActionResult> UpdateBrand([FromBody] BrandUpdateRequest request)
        {
            try
            {
                var brand = await Repo.Brand.GetBrand(request.Id, true);

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

                var obj = await Repo.Brand.GetBrandByName(request.Name);

                if (obj != null && obj.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return BadRequest(new Response
                    {
                        Errors = new List<string>
                        {
                            $"Thương hiệu {request.Name} đã tồn tại!"
                        }
                    });
                }

                brand.Name = request.Name;

                this.Repo.Brand.Update(brand);

                await this.Repo.Brand.SaveChanges();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = brand.ToDTO()
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
