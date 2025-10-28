using DataAccess;
using DataAccess.Contract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Service.Contract;

namespace Common.DependencyInjection;

public class Bootstrap
{
    public static void ConfigureService(IServiceCollection services, IConfiguration configuration)
    {
        //Data Access
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IBuildingRepository, BuildingRepository>();
        
        //Services
        services.AddTransient<IBuildingService, BuildingService>();
        


        // Add application services.
        //services.AddTransient<IEmailSender, AuthMessageSender>();
        //services.AddTransient<ICmsSender, AuthMessageSender>();


    }
}
