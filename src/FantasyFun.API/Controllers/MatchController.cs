using Microsoft.AspNetCore.Mvc;

namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetEntryMessage()
        {
            return "Match";
        }
    }
}
