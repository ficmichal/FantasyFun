using FantasyFun.Application.Settings;
using FantasyFun.Application.ViewModel;
using FantasyFun.DAL;
using Microsoft.EntityFrameworkCore;

namespace FantasyFun.Application
{
    internal class PlayersService : IPlayersService
    {
        private readonly DateTime _defaultGameTime;
        private readonly int _internalPlayersByOverallMaxNumber;
        private readonly FootballDbContext _dbContext;

        public PlayersService(GameSettings gameSettings, FootballDbContext dbContext)
        {
            _dbContext = dbContext;
            _defaultGameTime = gameSettings.DefaultGameTime;
            _internalPlayersByOverallMaxNumber = gameSettings.InternalPlayersByOverallMaxNumber;
        }

        public async Task<IEnumerable<string>> GetPlayersByOverall(long overall)
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
                .Take(_internalPlayersByOverallMaxNumber)
                .ToList();

            return anyPlayersWithOverall;
        }
    }
}
