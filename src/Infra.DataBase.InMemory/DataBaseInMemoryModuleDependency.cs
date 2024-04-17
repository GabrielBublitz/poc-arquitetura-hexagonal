using Api.Adapters;
using Domain.Adapters.DataBse;
using Domain.Entities;
using Infra.DataBase.InMemory.Connection;
using Infra.DataBase.InMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DataBase.InMemory
{
    public static class DataBaseInMemoryModuleDependency
    {
        public static void AddDataBaseModule(this IServiceCollection services)
        {
            services.AddScoped<IClubAdapter, ClubRepository>();
            services.AddTransient<IDBConnnectionProvider, MySqlConnectionProvider>();
            services.AddScoped<IDBContext, DBContext>();
        }
    }
}
