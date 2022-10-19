namespace FantasyFun.Application.UnitTests
{
    public class LeagueServiceTests
    {
        [Fact]
        public async Task ShouldReturnTeamName()
        {
            // Arrange
            var teamService = new TeamService(new StubTeamRepository());
            var id = 1;
            var longName = "Lech Poznań";
            var shortName = "LPO";

            // Arrange
            var teamName = await teamService.GetTeamById(id);

            // Assert
            Assert.Equal(longName, teamName.LongName);
            Assert.Equal(shortName, teamName.ShortName);
        }
    }
}
