using FantasyFun.DAL.Settings;
using FantasyFun.DAL.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    internal class PlayerRepository : IPlayerRepository
    {
        private readonly FootballDbContext _dbContext;
        private readonly DateTime _defaultGameTime;
        private readonly int _InternalPlayersByOverallMaxNumber;


        public PlayerRepository(FootballDbContext dbContext, GameSettings gameSettings)
        {
            _dbContext = dbContext;
            _defaultGameTime = gameSettings.DefaultGameTime;
            _InternalPlayersByOverallMaxNumber = gameSettings.InternalPlayersByOverallMaxNumber;

        }

        public async Task<IEnumerable<string>> GetPlayerByOverall(long overall)
        {
            var anyPlayers = await _dbContext.PlayerAttributes
               .Where(l => l.Date <= _defaultGameTime)
               .OrderByDescending(l => l.Date)
               .GroupBy(l => l.Player.Name)
               .Select(l => new PlayerType(l.FirstOrDefault().Player.Name, l.FirstOrDefault().OverallRating))
               .Take(500)
               .ToListAsync();

            var anyPlayersWithOverall = anyPlayers
                .Where(l => l.OverallRating == overall)
                .Select(l => l.Name)
                .Take(_InternalPlayersByOverallMaxNumber)
                .ToList();

            return anyPlayersWithOverall;
        }

        public async Task<IEnumerable<PlayerType>> GetPlayerById(int id)
        { 
            var allPlayers = await _dbContext.Players
                .Where(l => l.Id == id && l.Players.FirstOrDefault().Date <= _defaultGameTime)
                .OrderByDescending(l => l.Players.FirstOrDefault().Date)
                .Select(l => new PlayerType(l.Name, l.Players.FirstOrDefault().OverallRating))
                .FirstOrDefaultAsync();

            return allPlayers;  
        }
    }
}
