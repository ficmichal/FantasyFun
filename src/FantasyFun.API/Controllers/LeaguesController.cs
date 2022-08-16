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
        [Route("{id}")]
        public async Task<ActionResult<string>> GetAnyLeague(long id)
        {
            var db = new FootballDbContext();

            var anyLeague = await db.Leagues.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (anyLeague == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(anyLeague.Name);
        }
    }
}
