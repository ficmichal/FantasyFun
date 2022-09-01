using FantasyFun.API.Repositories;
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
        private readonly DateTime _defaultGameTime = new DateTime(2015, 3, 1);

        [HttpGet]
        [Route("overall/{overall}")]
        public async Task<ActionResult<List<string>>> GetAnyPlayers(long overall)
        {
            var db = new FootballDbContext();

            // TODO change to two separate queries (more readable approach)
            var anyPlayer = await db.PlayerAttributes
                .Where(l => l.Date <= _defaultGameTime)
                .OrderByDescending(l => l.Date)
                .GroupBy(l => new
                {
                    l.Player.Name,
                    l.OverallRating
                })
                .Select(l => new
                    {
                        PlayerName = l.FirstOrDefault().Player.Name,
                        Overall = l.FirstOrDefault().OverallRating,
                    })
                .Where(l => l.Overall == overall)
                .Select(l => l.PlayerName)
                .Take(100)
                .ToListAsync();

            if (anyPlayer == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyPlayer);
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PlayerType>> GetPlayersByOverall(int id)
        {
            var db = new FootballDbContext();
            

            var allPlayers = await db.Players
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

