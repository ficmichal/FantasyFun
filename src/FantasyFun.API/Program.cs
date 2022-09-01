using FantasyFun.API.Repositories;
using FantasyFun.API.Settings;

namespace FantasyFun.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            // 1. When the app is up, it runs on specific environment (Development, Staging, etc.)
            // 2. Builder has the info about env.
            // 3. Builder maps config from the related appsettings.json (appsettings.{env}.json)
            // 4. .GetSection("Db").Get<DbSettings>() maps Db JSON with its values from appsettings
            var dbSettings = builder.Configuration.GetSection("Db").Get<DbSettings>();
            builder.Services.AddScoped<FootballDbContext>(serviceProvider => new FootballDbContext(dbSettings));

            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();
            app.Run();
        }
    }
}