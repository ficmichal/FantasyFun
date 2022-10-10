using FantasyFun.DataMigrator.DbContexts;
using FantasyFun.DataMigrator.Settings;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var sqlLiteContext = new FootballDbContext();

var sqlServerContext = new SqlFootballDbContext();

var sqlLiteCountries = sqlLiteContext.Countries;

await sqlServerContext.Countries.AddRangeAsync(sqlLiteCountries);
await sqlServerContext.SaveChangesAsync();


var sqlLiteLeagues = sqlLiteContext.Leagues;

await sqlServerContext.Leagues.AddRangeAsync(sqlLiteLeagues);
await sqlServerContext.SaveChangesAsync();

var teams = sqlLiteContext.Teams;

await sqlServerContext.Teams.AddRangeAsync(teams);
await sqlServerContext.SaveChangesAsync();

var players = sqlLiteContext.Players;

await sqlServerContext.Players.AddRangeAsync(players);
await sqlServerContext.SaveChangesAsync();

var playerAttributes = sqlLiteContext.PlayerAttributes;

await sqlServerContext.PlayerAttributes.AddRangeAsync(playerAttributes);
await sqlServerContext.SaveChangesAsync();


