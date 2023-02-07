using FantasyFun.DataMigrator.DbContexts;
using FantasyFun.DataMigrator.Settings;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var sqlLiteContext = new FootballDbContext();

var SqlServerContext = new SqlFootballDbContext();

var sqlLiteCountries = sqlLiteContext.Countries;
await SqlServerContext.Countries.AddRangeAsync(sqlLiteCountries);
await SqlServerContext.SaveChangesAsync();

var sqlLiteLeague = sqlLiteContext.Leagues;
await SqlServerContext.Leagues.AddRangeAsync(sqlLiteLeague);
await SqlServerContext.SaveChangesAsync();

var sqlLitePlayer = sqlLiteContext.Players;
await SqlServerContext.Players.AddRangeAsync(sqlLitePlayer);
await SqlServerContext.SaveChangesAsync();

var sqlLitePlayerAttributes = sqlLiteContext.PlayerAttributes;
await SqlServerContext.PlayerAttributes.AddRangeAsync(sqlLitePlayerAttributes);
await SqlServerContext.SaveChangesAsync();

var sqlLiteTeam = sqlLiteContext.Teams;
await SqlServerContext.Teams.AddRangeAsync(sqlLiteTeam);
await SqlServerContext.SaveChangesAsync();

var sqlLiteMatch = sqlLiteContext.Matches;
await SqlServerContext.Matches.AddRangeAsync(sqlLiteMatch);
await SqlServerContext.SaveChangesAsync();