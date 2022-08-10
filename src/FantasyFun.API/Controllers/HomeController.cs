using Microsoft.AspNetCore.Mvc;

namespace FantasyFun.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetEntryMessage()
        {
            return "Welcome in FantasyFun!";
        }
    }
}
