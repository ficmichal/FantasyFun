using FantasyFun.DAL.ViewModel;

namespace FantasyFun.DAL.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<string>> GetPlayerByOverall(long overall);
        Task<PlayerType> GetPlayerById(int id);

        Task<long> SearchPlayerBy(string name);
    }
}
