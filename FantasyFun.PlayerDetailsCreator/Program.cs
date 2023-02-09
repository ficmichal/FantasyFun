using FantasyFun.DAL;
using FantasyFun.DAL.Settings;
using FantasyFun.PlayerDetailsCreator;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Start migration!");

var dbContext = new FootballDbContext(new DbSettings
{
    ConnectionString = "Server=.;Database=FantasyFun;Trusted_Connection=True;"
});




var players = await dbContext.Players.Include(x => x.Players).AsNoTracking().Take(10).ToListAsync();

Console.WriteLine("Player Attributes fetched!");

var playersDetails = new List<PlayerDetails>();

foreach (var player in players)
{
    var playerDetails = new PlayerDetails
    {
        Id = player.Id
    };
    var playerDetailsBySeason = player.Players
        .Select(x => new
        {
            Season = Seasons.GetSeason(x.Date),
            Overall = x.OverallRating
        })
        .GroupBy(x => x.Season)
        .Select(x => new PlayerDetailsBySeason
        {
            Season = x.Key,
            Overall = x.Max(x => x.Overall)
        })
        .ToList();
    playerDetails.PlayerDetailsBySeason = playerDetailsBySeason;
    playersDetails.Add(playerDetails);
}

var t = 0;