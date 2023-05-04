using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClothingShop.Server.Auth
{
    using ClothingShop.Model.Entities;
    using Model;

    public class AuthDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Identity");

            builder.Entity<ApplicationUser>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("uuid_generate_v4()");

            base.OnModelCreating(builder);
        }
    }

    public class AuthDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AuthDbContext>
    {
        public AuthDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<AuthDbContext>(options => 
                options.UseNpgsql(configuration.GetConnectionString("AuthConnectionString")));

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider.GetService<AuthDbContext>();
        }
    }
}
