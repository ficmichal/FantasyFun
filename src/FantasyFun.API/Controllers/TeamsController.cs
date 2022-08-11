using FantasyFun.API.Repositories;
using FantasyFun.API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TeamName>> GetAnyTeam(long id)
        {
            var db = new FootballDbContext();

            var anyTeam = await db.Teams
                .Where(l => l.Id == id)
                .Select(l => new TeamName
                {
                    LongName = l.LongName,
                    ShortName = l.ShortName
                }).FirstOrDefaultAsync();

            return anyTeam;
        }
    }
}
