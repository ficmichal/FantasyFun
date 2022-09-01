using FantasyFun.API.Repositories;
using FantasyFun.API.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        private readonly FootballDbContext _dbContext;

        public LeaguesController(FootballDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAnyLeague()
        {
            var anyLeague = await _dbContext.Leagues.FirstOrDefaultAsync();

            return anyLeague.Name;
        }
        [HttpGet]
        [Route("{country}")]
        public async Task<ActionResult<string>> GetLigueByCountry(string country)
        {
            var leagueName = await _dbContext.Leagues
                .Where(l => l.Country.Name == country)
                .Select(l=>l.Name)
                .FirstOrDefaultAsync();

            //var sql = db.Leagues.Where(l => l.Country.Name == country).Select(l => l.Name).ToQueryString();

            return leagueName;
        }
    }
}
