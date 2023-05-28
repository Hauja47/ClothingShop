using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Server.Controllers
{
    using ClothingShop.Model;
    using ClothingShop.Model.DTO;

    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ITokenService tokenService;
        private readonly IConfiguration config;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            ITokenService tokenService,
            IConfiguration config)
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
            this.config = config;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var user = new ApplicationUser
            {
                Email = request.Email,
                UserName = request.Email,
                Name = request.Name,
            };

            try
            {
                var userExists = await userManager.FindByEmailAsync(request.Email);
                if (userExists != null)
                    return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        new RegisterResponse {
                            Messages = new List<string> { "User already exists!" }
                        });

                if (request == null)
                    return BadRequest();

                var result = await userManager.CreateAsync(user, request.Password);
                if (!result.Succeeded)
                {
                    var errors = result.Errors.Select(e => e.Description);

                    return BadRequest(new RegisterResponse { Errors = errors });
                }
                else
                {
                    result = await userManager.AddToRoleAsync(user, ApplicationRole.CUSTOMER);

                    if (!result.Succeeded)
                    {
                        var errors = result.Errors.Select(e => e.Description);

                        return BadRequest(new RegisterResponse { Errors = errors });
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new RegisterResponse
                {
                    IsSuccess = false,
                    Errors = new List<string>
                    {
                        ex.Message, ex.StackTrace
                    }
                });
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(request.Email);

                if (user == null)
                    return NotFound(new LoginResponse
                    {
                        IsSuccess = false,
                        Errors = new List<string>()
                        {
                            "Account Not Found"
                        }
                    });


                if (!await userManager.CheckPasswordAsync(user, request.Password))
                    return Unauthorized(new LoginResponse
                    {
                        IsSuccess = false,
                        Errors = new List<string>()
                        {
                            "Invalid Authentication"
                        }
                    });

                var loginCredentials = tokenService.GetSigningCredentials();
                var claims = await tokenService.GetClaims(user);
                var tokenOptions = tokenService.GenerateTokenOptions(loginCredentials, claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                var refreshToken = tokenService.GenerateRefreshToken();

                int.TryParse(config["JWT:RefreshTokenValidityInDays"], out var refreshTokenValidityInDays);

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

                await userManager.UpdateAsync(user);

                return Ok(new LoginResponse
                {
                    IsSuccess = true,
                    AccessToken = token,
                    RefreshToken = refreshToken,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new LoginResponse
                {
                    IsSuccess = false,
                    Errors = new List<string>
                    {
                        ex.Message, ex.StackTrace
                    }
                });
            }
        }

        [HttpPost("Token/Refresh")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest request)
        {
            if (request is null)
            {
                return BadRequest("Invalid client request");
            }

            string? accessToken = request.AccessToken;
            string? refreshToken = request.RefreshToken;

            var principal = tokenService.GetPrincipalFromExpiredToken(accessToken);
            if (principal == null)
            {
                return BadRequest(new TokenResponse
                {
                    IsSuccess = false,
                    Errors = new List<string>
                    {
                        "Invalid access token or refresh token"
                    }
                });
            }

            string email = principal.Claims.Single(c => c.Type == ClaimTypes.Email).Value;

            var user = await userManager.FindByEmailAsync(email);

            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return BadRequest("Invalid access token or refresh token");
            }

            var claims = await tokenService.GetClaims(user);
            var loginCredentials = tokenService.GetSigningCredentials();
            var tokenOptions = tokenService.GenerateTokenOptions(loginCredentials, claims);
            var newAccessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            var newRefreshToken = tokenService.GenerateRefreshToken();

            int.TryParse(config["JWT:RefreshTokenValidityInDays"], out var refreshTokenValidityInDays);

            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
            user.RefreshToken = newRefreshToken;

            await userManager.UpdateAsync(user);

            return Ok(new TokenResponse
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
                IsSuccess = true,
            });
        }
    }
}
