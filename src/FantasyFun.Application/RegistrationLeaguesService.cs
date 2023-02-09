using FantasyFun.Application.Services;
using FantasyFun.Application.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    static public class RegistrationLeaguesService
    {
        static public void RegisterLeaguesService(this IServiceCollection service)
        {
            service.AddScoped<ILeaguesService, LeaguesService>();
        }
    }
}
