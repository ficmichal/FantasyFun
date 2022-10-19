using FantasyFun.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    public interface IPlayerService
    {
        public Task<IEnumerable<string>> GetPlayerByOverall(long overall);
        public Task<PlayerType> GetPlayerById(int id);
    }
}
