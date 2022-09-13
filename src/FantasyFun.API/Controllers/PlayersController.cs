using FantasyFun.API.Repositories;
using FantasyFun.API.Settings;
using FantasyFun.API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FantasyFun.API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly DateTime _defaultGameTime;

        private readonly FootballDbContext _dbContext;

        public PlayersController(FootballDbContext dbContext, GameSettings gameSettings)
        {
            _dbContext = dbContext;
            _defaultGameTime = gameSettings.DefaultGameTime;
        }

        [HttpGet]
        [Route("overall/{overall}")]
        public async Task<ActionResult<List<string>>> GetAnyPlayers(long overall)
        {
            //var db = new FootballDbContext();

            var anyPlayers = await _dbContext.PlayerAttributes
                .Where(l => l.Date <= _defaultGameTime)
                .OrderByDescending(l => l.Date)
                .GroupBy(l => l.Player.Name)//.Max(l => l.Select(k => k.Date))
                .Select(l => new PlayerType(l.FirstOrDefault().Player.Name, l.FirstOrDefault().OverallRating, l.FirstOrDefault().Date))
                .Take(500)
                .ToListAsync();

            var anyPlayersWithOverall = anyPlayers
                .Where(l => l.OverallRating == overall)
                .Select(l => l.Name)
                .Take(10)
                .ToList();


            if (anyPlayersWithOverall == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyPlayersWithOverall);
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PlayerType>> GetPlayersByOverall(int id)
        {
            //var db = new FootballDbContext();
            

            var allPlayers = await _dbContext.Players
                .Where(l => l.Id == id && l.Players.FirstOrDefault().Date <= _defaultGameTime)
                .OrderByDescending(l => l.Players.FirstOrDefault().Date)
                .Select(l => new PlayerType(l.Name, l.Players.FirstOrDefault().OverallRating, l.Players.FirstOrDefault().Date))
                .FirstOrDefaultAsync();

            if (allPlayers == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(allPlayers);
        }
       
    }
}

