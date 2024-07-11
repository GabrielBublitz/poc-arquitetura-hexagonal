using Domain.Adapters;
using Domain.Adapters.DataBse;
using Infra.DataBase.Connection;
using Infra.DataBase.Factories;
using Infra.DataBase.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DataBase
{
    public static class DataBaseModuleDependency
    {
        public static void AddDataBaseModule(this IServiceCollection services, string connecTionString)
        {
            services.AddScoped<IClubAdapter, ClubRepository>();
            services.AddScoped<IDBConnnectionProvider>(provider => new MySqlConnectionProvider(connecTionString));
            services.AddScoped<IDBContextFactory, DBContextFactory>();
        }
    }
}
