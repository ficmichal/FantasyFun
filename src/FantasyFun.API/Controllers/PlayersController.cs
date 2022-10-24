using FantasyFun.API.ViewModel;
using FantasyFun.Application;
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
        private readonly IPlayerService _playerService;

        public PlayersController(FootballDbContext dbContext, GameSettings gameSettings, IPlayerService playerService)
        {
            _playerService = playerService;
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
            var allPlayers = await _playerService.GetPlayerById(id);

            if (allPlayers == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(allPlayers);
        }
    }
}

