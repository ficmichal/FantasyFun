namespace FantasyFun.API.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        public string GetNameByCountry(string country)
        {
            var db = new FootballDbContext();

            var leagueName = db.Leagues
                .Where(l => l.Country.Name == country)
                .Select(l => l.Name)
                .FirstOrDefault();

            return leagueName;
        }
    }
}
