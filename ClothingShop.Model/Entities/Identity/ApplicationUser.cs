using Microsoft.AspNetCore.Identity;

namespace ClothingShop.Model
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }

        public string? Address { get; set; }

        public IEnumerable<Product> FavoriteProducts { get; set; }

        public IEnumerable<Promotion> UsedPromotions { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
