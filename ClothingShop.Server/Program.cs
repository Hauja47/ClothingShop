using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;

namespace ClothingShop.Server
{
    using DataAccess.Repositories;
    using DataAccess;
    using Model;

    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var builder = WebApplication.CreateBuilder(args);

            var migrationsAssembly = typeof(Program).Assembly.GetName().Name;

            // Add services to the container.

            builder.Services
                .AddControllers()
                .AddNewtonsoftJson();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ShopContext>(options =>
                options
                    .UseNpgsql(builder.Configuration.GetConnectionString("ShopConnectionString"))
                    .UseSnakeCaseNamingConvention());

            builder.Services
                .AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ShopContext>();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequiredLength = 8;

                // User settings
                options.User.RequireUniqueEmail = true;

                // Signin settings
                options.SignIn.RequireConfirmedEmail = true;
            });

            var jwtSettings = builder.Configuration.GetSection("JWT");
            builder.Services
                .AddAuthentication(opt =>
                {
                    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtSettings["ValidIssuer"],
                        ValidAudience = jwtSettings["ValidAudience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(jwtSettings.GetSection("SecurityKey").Value))
                    };
                });

            //builder.Services.AddScoped<JwtHandler>();
            builder.Services.AddScoped<ITokenService, TokenService>();
            builder.Services.AddTransient<Repositories>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}