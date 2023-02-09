using FantasyFun.DAL.DTO;

namespace FantasyFun.DAL.Repositories;

public interface IMatchRepository
{
    Task<GoalsInMatch> GetGoalScorersByMatchId(long matchId);
}