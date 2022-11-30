using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FantasyFun.Application.UnitTests
{
    public class PlayerServiceTest
    {
        [Fact]
        public async void shouldReturnPlayerByOverall()
        {
            //Arrange
            var Player = new PlayerService(new StubPlayerRepository());
            var overall = 1;
            var ExpectedPlayerName = "Aaron Appindangoye";

            //Act
            var PlayerName = await Player.GetPlayerByOverall(overall);

            //Assert
            Assert.Equal(ExpectedPlayerName, PlayerName.First());
        }


    }
}
