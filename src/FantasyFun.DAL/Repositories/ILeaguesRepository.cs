using FantasyFun.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public interface ILeaguesRepository
    {
        Task<IEnumerable<string>> GetLigueByCountry(string country);
        Task<IEnumerable<League>> GetAnyLeague();
    }
}
