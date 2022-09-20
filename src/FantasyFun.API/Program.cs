using FantasyFun.Application;
using FantasyFun.Application.Settings;
using FantasyFun.DAL;
using FantasyFun.DAL.Settings;

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

            var gameSettings = builder.Configuration.GetSection("GameSettings").Get<GameSettings>();
            builder.Services.AddScoped<GameSettings>(serviceProvider => gameSettings);

            builder.Services.RegisterPlayerService("Michal Fic");

            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();

            app.Run();
        }
    }
}