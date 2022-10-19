using FantasyFun.DAL.Repositories;
using FantasyFun.DAL.ViewModel;

namespace FantasyFun.Application.UnitTests
{
    public class StubTeamRepository : ITeamRepository
    {
        public Task<TeamName> GetTeamById(int id)
        {
            if (id == 1)
            {
                return Task.FromResult(new TeamName("Lech Poznań", "LPO"));
            }

            else
            {
                return Task.FromResult(new TeamName("Kotwica Korczyna", "KoKo"));
            }
        }
    }
}
