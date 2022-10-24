using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public static class LeaguesRegistration
    {
        public static void RegisterLeaguesRepository (this IServiceCollection service)
        {
            service.AddScoped<ILeaguesRepository,LeaguesRepository>(); 
        }
    }
}
