using FantasyFun.Application.ViewModel;
using FantasyFun.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaguesController : ControllerBase
    {
        private readonly ILeaguesService _dbContext;

        public LeaguesController(ILeaguesService dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAnyLeague()
        {

            var anyLeague = _dbContext.GetAnyLeague();
            
            if(anyLeague == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyLeague.Name);


        }
        [HttpGet]
        [Route("{country}")]
        public async Task<ActionResult<string>> GetLeagueByCountry(string country)
        {

            var leagueName = _dbContext.GetLeagueByCountry(country);

            if (leagueName == null)
            {
                return NotFound(string.Empty);
            }

            //var sql = db.Leagues.Where(l => l.Country.Name == country).Select(l => l.Name).ToQueryString();

            return Ok(leagueName);
        }
       
       
    }
}
