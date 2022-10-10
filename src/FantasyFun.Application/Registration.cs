using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    public static class Registration
    {
        public static void RegisterPlayerService( this IServiceCollection services)
        {
                services.AddScoped<IPlayerService,PlayerService>();
        }
    }
}
