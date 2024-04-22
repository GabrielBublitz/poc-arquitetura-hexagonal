using Domain.Adapters;
using Domain.Adapters.DataBse;
using Domain.Entities;
using Infra.DataBase.Connection;
using Infra.DataBase.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DataBase
{
    public static class DataBaseModuleDependency
    {
        public static void AddDataBaseModule(this IServiceCollection services)
        {
            services.AddScoped<IClubAdapter, ClubRepository>();
            services.AddTransient<IDBConnnectionProvider, MySqlConnectionProvider>();
            services.AddScoped<IDBContext, DBContext>();
        }
    }
}
