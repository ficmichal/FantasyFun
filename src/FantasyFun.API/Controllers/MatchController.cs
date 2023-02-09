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

        [HttpGet]
        public ActionResult<GoalsInMatch> GetGoalScorers(long matchId)
        {
            return "Match";
        }


    }
    public class GoalsInMatch
    {
        public List<GoalInMatch> WhoScored { get; set; } = new List<GoalInMatch>();
    }

    public class GoalInMatch
    {
        public string PlayerName { get; set; }
        public int NumberOfGoals { get; set; }
    }
    // 1. W MatchController => MatchService => MatchRepository (standardowe podejscie) utwórz metodę która po danym MatchId wyszuka wszystkich strzelców bramek.
    // 2. Pamiętaj że będziesz musiał użyć XmlSerializera (hehehehee) do deserializacji pola goal (z SQL które jest stringiem) na obiekt C# Goal!!!!! Użyj obiektu stworzonego w testach. Oczywiście skopiuj jako nowa klasa w projekcie DAL.
    // 3. Wynikiem niech będzie obiekt GoalsInMatch (także klasa z testu).
    // 4. Bazuj na szkicu.
}
