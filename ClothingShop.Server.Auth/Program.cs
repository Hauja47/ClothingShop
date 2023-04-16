using Microsoft.EntityFrameworkCore;

namespace ClothingShop.Server.Auth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var assembly = typeof(Program).Assembly.GetName().Name;

            builder.Services.AddIdentityServer()
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = dbContextBuilder =>
                        dbContextBuilder.UseNpgsql(
                            builder.Configuration.GetConnectionString("ShopConnectionString"),
                            options => options.MigrationsAssembly(assembly))
                        .UseSnakeCaseNamingConvention();
                })
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = dbContextBuilder =>
                        dbContextBuilder.UseNpgsql(
                            builder.Configuration.GetConnectionString("ShopConnectionString"),
                            options => options.MigrationsAssembly(assembly))
                        .UseSnakeCaseNamingConvention();
                })
                .AddDeveloperSigningCredential();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}