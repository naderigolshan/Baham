using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Baham.DataLayer.Context;
using Baham.ViewModels.Application;

namespace Baham.IoCConfig;

public static class AddCustomServicesExtension
{
    public static IServiceCollection AddCustomeService(this IServiceCollection services)
    {
        var provider = services.BuildServiceProvider();
        var connectionStrings = provider.GetRequiredService<IOptionsMonitor<ConnectionStrings>>().CurrentValue;

        services.AddDbContext<BahamDbContext>(options =>
        {
            options.UseNpgsql(connectionStrings.BahamDbContextConnection);
        });


        return services;
    }
}
