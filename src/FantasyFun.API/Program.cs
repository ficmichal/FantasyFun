using FantasyFun.API.Repositories;
using FantasyFun.API.Settings;

namespace FantasyFun.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRouting();

            builder.Services.AddControllers();

            var dbSettings = builder.Configuration.GetSection("Db").Get<DbSettings>();
            builder.Services.AddScoped<FootballDbContext>(serviceProvider => new FootballDbContext(dbSettings));

            var GameSettings = builder.Configuration.GetSection("GameSettings").Get<GameSettings>();
            builder.Services.AddScoped<GameSettings>(serviceProvider => GameSettings);

            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();

            app.Run();
            
        }
    }
}