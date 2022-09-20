using Microsoft.Extensions.DependencyInjection;

namespace FantasyFun.Application
{
    public static class Registrations
    {
        public static void RegisterDummyNamedPlayerService(this IServiceCollection services, string name)
        {
            if (name is "Mikołaj Wojewoda")
            {
                services.AddScoped<IPlayersService, WojewodaPlayersService>();
            }
            else
            {
                services.AddScoped<IPlayersService, FicPlayersService>();
            }
        }

        public static void RegisterPlayerService(this IServiceCollection services, string name)
        {
            services.AddScoped<IPlayersService, PlayersService>();
        }
    }
}
