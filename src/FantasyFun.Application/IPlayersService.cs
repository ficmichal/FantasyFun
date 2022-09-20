namespace FantasyFun.Application;

public interface IPlayersService
{
    public Task<IEnumerable<string>> GetPlayersByOverall(long overall);
}