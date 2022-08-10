using Microsoft.EntityFrameworkCore;

namespace FantasyFun.API.Repositories
{
    public class FootballDbContext : DbContext
    {
        public const string DbPath = "data\\database.sqlite";
        public readonly string ConnectionString;

        public FootballDbContext()
        {
            var folder = Directory.GetCurrentDirectory();
            ConnectionString = Path.Combine(folder, "..", "..", DbPath);
        }


    }
}
