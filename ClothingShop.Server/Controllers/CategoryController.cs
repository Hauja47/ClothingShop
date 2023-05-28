using ClothingShop.DataAccess;
using ClothingShop.Model.DTO;
using ClothingShop.Model.Extensions;
using ClothingShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    public class CategoryController : BaseController
    {
        public CategoryController(ShopContext context) : base(context)
        {
        }

        #region Category

        [HttpPost("Categories")]
        public async Task<IActionResult> AddCategory([FromBody] CategoryRequest request)
        {
            try
            {
                var obj = await Repo.Category.GetCategoryByName(request.Name);

                if (obj != null && obj.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return BadRequest(new Response
                    {
                        Errors = new List<string>
                        {
                            $"Danh mục {request.Name} đã tồn tại!"
                        }
                    });
                }

                var category = new Category()
                {
                    Name = request.Name,
                };

                this.Repo.Category.Add(category);

                await this.Repo.Category.SaveChanges();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = category.ToDTO()
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

        [HttpGet("Categories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await Repo.Category.GetCategories();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = categories.ToDTO()
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

        [HttpGet("Category/{id}")]
        public async Task<IActionResult> GetCategory([FromRoute] Guid id)
        {
            try
            {
                var category = await Repo.Category.GetCategory(id);

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

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = category.ToDTO()
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

        [HttpPatch("Category")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryUpdateRequest request)
        {
            try
            {
                var category = await Repo.Category.GetCategory(request.Id, true);

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

                var obj = await Repo.Category.GetCategoryByName(request.Name);

                if (obj != null && obj.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return BadRequest(new Response
                    {
                        Errors = new List<string>
                        {
                            $"Danh mục {request.Name} đã tồn tại!"
                        }
                    });
                }

                category.Name = request.Name;

                this.Repo.Category.Update(category);

                await this.Repo.Category.SaveChanges();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = category.ToDTO()
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
