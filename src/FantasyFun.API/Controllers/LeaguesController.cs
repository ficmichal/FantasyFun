using FantasyFun.API.Repositories;
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
            var db = new FootballDbContext();

            var anyLeague = await db.Leagues.FirstOrDefaultAsync();
            
            if(anyLeague == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyLeague.Name);


        }
        [HttpGet]
        [Route("{country}")]
        public async Task<ActionResult<string>> GetLigueByCountry(string country)
        {
            var db = new FootballDbContext();

            var leagueName = await db.Leagues
                .Where(l => l.Country.Name == country)
                .Select(l=>l.Name)
                .FirstOrDefaultAsync();

            if (leagueName == null)
            {
                return NotFound(string.Empty);
            }

            //var sql = db.Leagues.Where(l => l.Country.Name == country).Select(l => l.Name).ToQueryString();

            return Ok(leagueName);
        }
       
       
    }
}
