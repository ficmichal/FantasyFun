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
        public async Task<ActionResult<TeamName>> GetTeamById(long id)
        {
            var db = new FootballDbContext();

            var team = await db.Teams
                .Where(l => l.Id == id)
                .Select(l => new TeamName(l.LongName,l.ShortName))
                .FirstOrDefaultAsync();

            if (team == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(team);
        }
    }
}
