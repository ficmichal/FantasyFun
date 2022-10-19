using FantasyFun.Application.ViewModel;
using FantasyFun.DAL.Models;
using FantasyFun.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyFun.Application.ViewModel;
using League = FantasyFun.Application.ViewModel.League;

namespace FantasyFun.Application
{
    internal class LeaguesService : ILeaguesService
    {
        private readonly ILeaguesRepository _leaguesRepo;
        public LeaguesService(ILeaguesRepository leaguesRepo)
        {
            _leaguesRepo = leaguesRepo;
        }

        public async Task<League> GetAnyLeague()
        {
            var anyLeague = await  _leaguesRepo.GetAnyLeague();
            return new League(anyLeague.Id, anyLeague.Name);
        }

        public async Task<string> GetLeagueByCountry(string country)
        {
            var leagueName = await _leaguesRepo.GetLigueByCountry(country);
            return leagueName;
        }
    }
}
