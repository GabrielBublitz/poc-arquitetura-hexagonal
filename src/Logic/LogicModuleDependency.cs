using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Logic
{
    public static class LogicModuleDependency
    {
        public static void AddLogicModule(this IServiceCollection services)
        {
            services.AddTransient<IClubService, ClubServiceManager>();
        }
    }
}
