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
            return anyLeague.Name;
        }
    }
}
