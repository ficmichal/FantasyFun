using FantasyFun.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    internal class LeaguesRepository : ILeaguesRepository
    {
        private readonly FootballDbContext _dbContext;

        public LeaguesRepository(FootballDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<League> GetAnyLeague()
        {
            var anyLeague = await _dbContext.Leagues.FirstOrDefaultAsync();
            return anyLeague;
        }

        public async Task<string> GetLigueByCountry(string country)
        {
            var leagueName = await _dbContext.Leagues
                .Where(l => l.Country.Name == country)
                .Select(l => l.Name)
                .FirstOrDefaultAsync();

            return leagueName;
        }
    }
}
