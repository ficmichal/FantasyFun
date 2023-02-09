using FantasyFun.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application.Services
{
    public interface ILeaguesService
    {
        Task<string> GetLeagueByCountry(string country);
        Task<League> GetAnyLeague();
    }
}
