using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FantasyFun.Application.UnitTests
{
    public class LeagueServiceTests
    {
        [Fact]
        public async void ShouldReturnTeamName()
        {
            //arrange
            var teamService = new TeamService(new StubTeamRepository());
            var id = 1;
            var longName = "Lech Poznań";
            var shortName = "LPO";
            //act
            var teamName = await teamService.GetTeamById(id);

            //assert
            Assert.Equal(longName, teamName.LongName);
            Assert.Equal(shortName, teamName.ShortName);
        }

    }
}
