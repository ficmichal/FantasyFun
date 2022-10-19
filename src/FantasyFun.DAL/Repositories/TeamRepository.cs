using FantasyFun.DAL.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFun.DAL.Repositories
{
    public class TeamRepository:ITeamRepository
    {
        private readonly FootballDbContext _dbContext;

        public TeamRepository(FootballDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TeamName> GetTeamById(int id)
        {
            var team = await _dbContext.Teams
                .Where(l => l.Id == id)
                .Select(l => new TeamName(l.LongName, l.ShortName))
                .FirstOrDefaultAsync();

            return team;
        }
    }
}
