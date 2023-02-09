namespace FantasyFun.Application.Services;

public interface IMatchService
{
    Task<object> GetGoalScorersByMatchId(long matchId);
}