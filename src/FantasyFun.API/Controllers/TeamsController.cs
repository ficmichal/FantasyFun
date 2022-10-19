using FantasyFun.API.ViewModel;
using FantasyFun.Application;
using FantasyFun.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {

        private readonly ITeamService _dbContext;

        public TeamsController(ITeamService dbcontext)
        {
            _dbContext = dbcontext;
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TeamName>> GetTeamById(int id)
        {
            var team = await _dbContext.GetTeamById(id);

            if (team == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(team);
        }
    }
}
