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
            builder.Services.AddScoped<FootballDbContext>(serviceProvider => new FootballDbContext(new DbSettings()));

            var app = builder.Build();

            app.UseRouting();

            app.MapControllers();
            app.Run();
        }
    }
}