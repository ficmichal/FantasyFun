using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    static public class TeamRegistration
    {
        static public void RegisterTeamRepository(this IServiceCollection services)
        {
            services.AddScoped<ITeamRepository, TeamRepository>();
        }
    }
}
