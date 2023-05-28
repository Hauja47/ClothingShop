using Microsoft.AspNetCore.Identity;

namespace ClothingShop.Model
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public const string ADMIN = "Admin";

        public const string EMPLOYEE = "Employee";

        public const string CUSTOMER = "Customer";
    }
}
