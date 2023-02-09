using FantasyFun.API.ViewModel;
using FantasyFun.Application.Services;
using Microsoft.AspNetCore.Mvc;
namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TeamName>> GetTeamById(int id)
        {
            var team = await _teamService.GetTeamById(id);

            if (team == null)
            {
                return NotFound(string.Empty);
            }

            return Ok(team);
        }
    }
}
