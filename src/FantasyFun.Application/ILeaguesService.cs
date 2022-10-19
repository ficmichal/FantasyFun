using FantasyFun.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application.ViewModel
{
    public interface ILeaguesService
    {
        Task<IEnumerable<string>> GetLeagueByCountry(string country);
        Task<IEnumerable<League>> GetAnyLeague();
    }
}
