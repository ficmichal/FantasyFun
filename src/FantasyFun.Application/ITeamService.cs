using FantasyFun.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamName>> GetTeamById(int id);
    }
}
