using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ccc.API.Infrastructure.Lookup;
using ccc.API.Features.Users;
using ccc.API.Features.Players;

namespace ccc.API
{
    public partial class Startup
    {
        public static void ConfigureScopedServices(IServiceCollection services)
        {
            //Shared
            services.AddScoped<ILookupRepository, LookupRepository>();

            //Players
            services.AddScoped<IPlayersService, PlayersService>();
            services.AddScoped<IPlayersRepository, PlayersRepository>();
            services.AddScoped<IPlayerSeasonsRepository, PlayerSeasonsRepository>();

            //Users
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
