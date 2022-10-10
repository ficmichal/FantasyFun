using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public static class PlayerRegistration
    {
        public static void RegisterPlayerRepository (this IServiceCollection services)
        {
            services.AddScoped<IPlayerRepository, PlayerRepository>();
        }
    }
}
