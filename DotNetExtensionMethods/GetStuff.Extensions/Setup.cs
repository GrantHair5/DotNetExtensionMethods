using GetStuff.Services;
using GetStuff.Services.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GetStuff.Extensions
{
    public static class Setup
    {
        public static void SetupGetStuffServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IGetStuffService, GetStuffService>();
            services.Configure<CarSettings>(options => configuration.GetSection(nameof(CarSettings)));
        }
    }
}