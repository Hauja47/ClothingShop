using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Model
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public const string ADMIN = "Admin";

        public const string EMPLOYEE = "Employee";

        public const string CUSTOMER = "Customer";
    }
}
