using FantasyFun.API.Models;
using FantasyFun.API.Repositories;
using FantasyFun.API.Settings;
using FantasyFun.API.ViewModel;
using FantasyFun.API.ViewModel.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace FantasyFun.API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly DateTime _defaultGameTime;

        private readonly FootballDbContext _dbContext;

        private readonly int _InternalPlayersByOverallMaxNumber;

        public PlayersController(FootballDbContext dbContext, GameSettings gameSettings)
        {
            _dbContext = dbContext;
            _defaultGameTime = gameSettings.DefaultGameTime;
            _InternalPlayersByOverallMaxNumber = gameSettings.InternalPlayersByOverallMaxNumber;
        }

        [HttpGet]
        [Route("overall/{overall}")]
        public async Task<ActionResult<List<string>>> GetAnyPlayers(long overall)
        {
            var anyPlayers = await _dbContext.PlayerAttributes
                .Where(l => l.Date <= _defaultGameTime)
                .OrderByDescending(l => l.Date)
                .GroupBy(l => l.Player.Name)
                .Select(l => new PlayerType(l.FirstOrDefault().Player.Name, l.FirstOrDefault().OverallRating))
                .Take(500)
                .ToListAsync();

            var anyPlayersWithOverall = anyPlayers
                .Where(x => x.OverallRating == overall)
                .Select(l => l.Name)
                .Take(_InternalPlayersByOverallMaxNumber)
                .ToList();

            if (anyPlayersWithOverall == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyPlayersWithOverall);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<string>>> FilterPlayers(PlayerFilters playerFilters)
        {
            // Specification implements method IsSatisfied() whcih returns Expression<Func<PlayerAttribute>>
            // FilterByNameSpecification : Specification
            // var specBuilder = new PlayersSearchSpecification(PlayerFilters playerFilters);

            // inside specBulider
            // {
            //  var specification = EmptySpec() : Specification;
            //  if (players.Filters.Name is not null)
            //  {
            //     specification.And(new FilterByNameSpecification(playerFilters.Name)) 4
            //  }else
            //  {
            //      // do nothing
            //  }

            // 



            var anyPlayers = await _dbContext.PlayerAttributes
                .Where(l => l.Date <= _defaultGameTime)
                .Where(playerFilters.FilterByName())
                .OrderByDescending(l => l.Date)
                .GroupBy(l => l.Player.Name)
                .Select(l => new PlayerType(l.FirstOrDefault().Player.Name, l.FirstOrDefault().OverallRating))
                .Take(500)
                .ToListAsync();

            var anyPlayersWithOverall = anyPlayers
                .Where(x => x.OverallRating == playerFilters.Overall)
                .Select(l => l.Name)
                .Take(_InternalPlayersByOverallMaxNumber)
                .ToList();

            if (anyPlayersWithOverall == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyPlayersWithOverall);
        }

        //public Func<PlayerType, bool> FilterByOverall(long overall)
        //{
        //    return x => x.OverallRating == overall;
        //}

        //public Expression<Func<Player_Attribute, bool>> FilterByGameTime()
        //{
        //    return l => l.Date <= _defaultGameTime;
        //}

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PlayerType>> GetPlayersByOverall(int id)
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

