using FantasyFun.Application.ViewModel;
using FantasyFun.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.Application
{
    internal class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepo;

        public TeamService(ITeamRepository teamRepo)
        {
            _teamRepo = teamRepo;
        }

        public async Task<TeamName> GetTeamById(int id)
        {
            var team = await _teamRepo.GetTeamById(id);
            return new TeamName(
                team.LongName,
                team.ShortName,
                $"{team.ShortName} - {team.LongName}");
        }
    }
}

