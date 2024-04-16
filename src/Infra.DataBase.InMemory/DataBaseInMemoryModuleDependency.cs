using Api.Adapters;
using Infra.DataBase.InMemory.Context;
using Infra.DataBase.InMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DataBase.InMemory
{
    public static class DataBaseInMemoryModuleDependency
    {
        public static void AddDataBaseModule(this IServiceCollection services)
        {
            services.AddScoped<IClubAdapter, ClubRepository>();
            services.AddTransient<IDBConnnectionAdapter, MySqlContext>();
        }
    }
}
