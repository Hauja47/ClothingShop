//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.AspNetCore.Identity;

//namespace ClothingShop.DataAccess.Configurations
//{
//    using Model;

//    public class IdentityRoleTableDefination : IEntityTypeConfiguration<IdentityRole<Guid>>
//    {
//        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
//        {
//            builder.HasData(
//                new IdentityRole<Guid>
//                {
//                    Id = Guid.NewGuid(),
//                    Name = "Customer",
//                    NormalizedName = "CUSTOMER"
//                },
//                new IdentityRole<Guid>
//                {
//                    Id = Guid.NewGuid(),
//                    Name = "Employee",
//                    NormalizedName = "EMPLOYEE"
//                },
//                new IdentityRole<Guid>
//                {
//                    Id = Guid.NewGuid(),
//                    Name = "Administrator",
//                    NormalizedName = "ADMINISTRATOR"
//                }
//            );
//        }
//    }
//}
