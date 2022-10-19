using FantasyFun.Application.ViewModel;
using FantasyFun.DAL.Models;
using FantasyFun.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    internal class LeaguesService : ILeaguesService
    {
        private readonly ILeaguesRepository _leaguesRepo;
        public LeaguesService(ILeaguesRepository leaguesRepo)
        {
            _leaguesRepo = leaguesRepo;
        }

        public Task<IEnumerable<League>> GetAnyLeague()
        {
            var anyLeague = _leaguesRepo.GetAnyLeague();
            return anyLeague;
        }

        public async Task<IEnumerable<string>> GetLeagueByCountry(string country)
        {
            var leagueName = await _leaguesRepo.GetLigueByCountry(country);
            return leagueName;
        }
    }
}
