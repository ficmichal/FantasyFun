using FantasyFun.API.Requests;
using FantasyFun.API.ViewModel;
using FantasyFun.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
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
        
        [HttpPost]
        public async Task<ActionResult<long>> SearchPlayers(SearchPlayer searchPlayerRequest)
        {
            var playerOverall = await _playerService.Search(new Application.ViewModel.SearchPlayer(searchPlayerRequest.Name, searchPlayerRequest.Overall));

            if (playerOverall == 0)
            {
                return NotFound(string.Empty);
            }

            return Ok(playerOverall);
        }
    }
}

