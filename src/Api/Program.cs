using Infra.DataBase.InMemory;
using Infra.Email;
using Logic;

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
            builder.Services.AddDataBaseModule();
            builder.Services.AddEmailModule();
            builder.Services.AddLogicModule();
        }
    }
}
