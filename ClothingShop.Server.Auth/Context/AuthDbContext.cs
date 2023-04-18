using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothingShop.Server.Auth
{
    using Microsoft.EntityFrameworkCore.Design;
    using Model;

    public class AuthDbContext : IdentityDbContext<User, Role, Guid>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Identity");

            builder.Entity<User>()
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
