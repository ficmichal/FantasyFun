using FantasyFun.DAL.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public static class FootballDbContextRegistration
    {
        public static void RegisterFootballDbContext(this IServiceCollection service, DbSettings dbSettings)
        {
            service.AddScoped<FootballDbContext>(serviceProvider => new FootballDbContext(dbSettings));
        }
    }
}
