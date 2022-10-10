using FantasyFun.API.ViewModel;
using FantasyFun.Application;
using FantasyFun.Application.Settings;
using FantasyFun.DAL;
using FantasyFun.DAL.Settings;
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
        private readonly IPlayerService _playerService;

        private readonly int _InternalPlayersByOverallMaxNumber;

        public PlayersController(FootballDbContext dbContext, GameSettings gameSettings, IPlayerService playerService)
        {
            _dbContext = dbContext;
            _playerService = playerService;
            _defaultGameTime = gameSettings.DefaultGameTime;
            _InternalPlayersByOverallMaxNumber = gameSettings.InternalPlayersByOverallMaxNumber;
        }

        [HttpGet]
        [Route("overall/{overall}")]
        public async Task<ActionResult<List<string>>> GetAnyPlayers(long overall)
        {

            var anyPlayersWithOverall = await _playerService.GetPlayerByOverall(overall);

            if (anyPlayersWithOverall == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyPlayersWithOverall);
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PlayerType>> GetPlayersById(int id)
        {
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

