using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public class PlayerRepository
    {
        // 0. Implements IPlayerRepository.
        // 1. Make PlayerRepository internal.
        // 2. Inject FootballDbContext and Dbsettings here via constructor.
        // 3. Add code in method from PlayerService
        // var anyPlayers = await _dbContext.PlayerAttributes
        // .Where(l => l.Date <= _defaultGameTime)
        // .OrderByDescending(l => l.Date)
        // .GroupBy(l => l.Player.Name)
        // .Select(l => new PlayerType(l.FirstOrDefault().Player.Name, l.FirstOrDefault().OverallRating))
        // .Take(500)
        // .ToListAsync();
        // 
        // var anyPlayersWithOverall = anyPlayers
        // .Where(l => l.OverallRating == overall)
        // .Select(l => l.Name)
        // .Take(_internalPlayersByOverallMaxNumber)
        // .ToList();

        // 4. In PlayerService change FootballDbContext to IPlayerRepository in constuctor
        // 5. Invoke that method IPlayerRepository.GetPlayersByOverall()
        // 6. Register IPlayerRepository in DAL project as extension method (like IPlayerService in Application)
    }
}
