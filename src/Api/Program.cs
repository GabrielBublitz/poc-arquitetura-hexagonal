using Infra.DataBase;
using Infra.Email;
using Logic;
using Logic.CommandHandler;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            SetupContainer(builder);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            SetupApplicationModules(builder);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        private static void SetupContainer(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
        }

        private static void SetupApplicationModules(WebApplicationBuilder builder)
        {
            var config = builder.Configuration;

            var jwtKey = config["jwt:secretKey"];
            var jwtIssuer = config["jwt:issuer"];
            var jwtAudience = config["jwt:audience"];

            string connectionString = config.GetConnectionString("MySqlConnectionString");

            builder.Services.AddDataBaseModule(connectionString);
            builder.Services.AddEmailModule();
            builder.Services.AddLogicModule();
            builder.Services.AddAuthorization();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtIssuer,
                    ValidAudience = jwtAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
                typeof(Program).Assembly, 
                typeof(GetDataBaseStatusCommandHandler).Assembly)
            );
        }
    }
}
