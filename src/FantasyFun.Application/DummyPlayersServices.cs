namespace FantasyFun.Application
{
    internal class WojewodaPlayersService : IPlayersService
    {
        public Task<IEnumerable<string>> GetPlayersByOverall(long overall)
        {
            return Task.FromResult(new List<string> {"Mikołaj Wojewoda"}.AsEnumerable());
        }

        public bool CheckLewandowski(string value)
        {
            return value.ContainsLewandowski();
        }
    }

    internal class FicPlayersService : IPlayersService
    {
        public Task<IEnumerable<string>> GetPlayersByOverall(long overall)
        {
            return Task.FromResult(new List<string> {"Michał Fic"}.AsEnumerable());
        }
    }
}
