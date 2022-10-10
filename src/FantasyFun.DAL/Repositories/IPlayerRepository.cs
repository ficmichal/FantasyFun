using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<string>> GetPlayerByOverall(long overall);
    }
}
