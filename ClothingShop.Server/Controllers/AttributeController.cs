using ClothingShop.DataAccess;
using ClothingShop.Model.DTO;
using ClothingShop.Model.Extensions;
using ClothingShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    public class AttributeController : BaseController
    {
        public AttributeController(ShopContext context) : base(context)
        {
        }

        #region Attribute

        [HttpPost("Attributes")]
        public async Task<IActionResult> AddAttribute([FromBody] AttributeRequest request)
        {
            try
            {
                var obj = await Repo.Attribute.GetAttributeByName(request.Name);

                if (obj != null && obj.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return BadRequest(new Response
                    {
                        Errors = new List<string>
                        {
                            $"Thuộc tính {request.Name} đã tồn tại!"
                        }
                    });
                }

                var attribute = new Model.Attribute
                {
                    Name = request.Name
                };

                this.Repo.Attribute.Add(attribute);

                await this.Repo.Attribute.SaveChanges();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = attribute.ToDTO()
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

        [HttpGet("Attribute/{id}")]
        public async Task<IActionResult> GetAttribute([FromRoute] Guid id)
        {
            try
            {
                var attribute = await Repo.Attribute.GetAttribute(id);

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

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = attribute.ToDTO()
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

        [HttpGet("Attributes")]
        public async Task<IActionResult> GetAttributes()
        {
            try
            {
                var attributes = await Repo.Attribute.GetAttributes();

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = attributes.ToDTO()
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

        [HttpPut("Attribute")]
        public async Task<IActionResult> UpdateAttribute([FromBody] AttributeUpdateRequest request)
        {
            try
            {
                var attribute = await Repo.Attribute.GetAttribute(request.Id);

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

                var obj = await Repo.Attribute.GetAttributeByName(request.Name);

                if (obj != null && obj.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return BadRequest(new Response
                    {
                        Errors = new List<string>
                        {
                            $"Thuộc tính {request.Name} đã tồn tại!"
                        }
                    });
                }

                attribute.Name = request.Name;

                return Ok(new Response
                {
                    IsSuccess = true,
                    Payload = attribute.ToDTO()
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
