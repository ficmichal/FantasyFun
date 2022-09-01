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

            var anyPlayer = await db.PlayerAttributes
                .Where(l => l.OverallRating == overall && l.Date <= _defaultGameTime)
                .OrderByDescending(l => l.Date)
                .GroupBy(l => l.Player.Name)//.Max(l => l.Select(k => k.Date))
                .Select(l => l.FirstOrDefault()).Select(l => l.Player.Name)
                .Take(100)
                .ToListAsync();
            
            if(anyPlayer == null)
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

