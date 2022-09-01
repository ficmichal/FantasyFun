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
        [HttpGet]
        public async Task<ActionResult<string>> GetAnyLeague()
        {
            var db = new FootballDbContext(new DbSettings());

            var anyLeague = await db.Leagues.FirstOrDefaultAsync();

            return anyLeague.Name;
        }
        [HttpGet]
        [Route("{country}")]
        public async Task<ActionResult<string>> GetLigueByCountry(string country)
        {
            var db = new FootballDbContext(new DbSettings());

            var leagueName = await db.Leagues
                .Where(l => l.Country.Name == country)
                .Select(l=>l.Name)
                .FirstOrDefaultAsync();

            //var sql = db.Leagues.Where(l => l.Country.Name == country).Select(l => l.Name).ToQueryString();

            return leagueName;
        }
    }
}
