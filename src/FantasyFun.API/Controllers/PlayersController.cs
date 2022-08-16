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
        [HttpGet]
        [Route("overall/{overall}")]
        public async Task<ActionResult<List<string>>> GetAnyPlayers(long overall)
        {
            var db = new FootballDbContext();

            var anyPlayer = await db.PlayerAttributes
                .Where(l => l.OverallRating == overall)
                .Select(l => l.Player.Name).Take(10).ToListAsync();
                

            return anyPlayer;
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PlayerType>> GetPlayersByOverall(int id)
        {
            var db = new FootballDbContext();

            var allPlayers = await db.Players
                .Where(l => l.Id == id)
                .Select(l => new PlayerType(l.Name, l.Players.FirstOrDefault().OverallRating)).FirstOrDefaultAsync();

            return allPlayers;


            
        }
       
    }
}

