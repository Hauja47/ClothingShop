using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model.DTO
{

    public class RegisterRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
    }

    public class RegisterResponse : BaseResponse
    {
    }

    public class LoginRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public class LoginResponse : BaseResponse
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }

    public class TokenRequest
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }

    public class TokenResponse : BaseResponse
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
