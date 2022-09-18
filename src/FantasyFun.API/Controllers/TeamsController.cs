using FantasyFun.API.Repositories;
using FantasyFun.API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FantasyFun.API.Settings;
namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {

        private readonly FootballDbContext _dbContext;

        public TeamsController(FootballDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TeamName>> GetTeamById(long id)
        {
            var team = await _dbContext.Teams
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
