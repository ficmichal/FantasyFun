using FantasyFun.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    static public class RegistrationTeamService
    {
        static public void RegisterTeamService(this IServiceCollection service)
        {
            service.AddScoped<ITeamService, TeamService>();
        }
    }
}
