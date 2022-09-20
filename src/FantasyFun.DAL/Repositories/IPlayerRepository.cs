namespace FantasyFun.DAL.Repositories;

public interface IPlayerRepository
{
    Task<IEnumerable<string>> GetPlayersByOverall(long overall);
}