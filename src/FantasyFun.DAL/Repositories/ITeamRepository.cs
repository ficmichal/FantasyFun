using FantasyFun.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public interface ITeamRepository
    {
        Task<TeamName> GetTeamById(int id);
    }
}
