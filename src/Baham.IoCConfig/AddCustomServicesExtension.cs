using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Baham.DataLayer.Context;
using Baham.ViewModels.Application;
using Microsoft.AspNetCore.Identity;
using Baham.Entities;
using Baham.Services.Interfaces.Identity;

namespace Baham.IoCConfig;

public static class AddCustomServicesExtension
{
    public static IServiceCollection AddCustomeService(this IServiceCollection services)
    {
        var provider = services.BuildServiceProvider();
        var connectionStrings = provider.GetRequiredService<IOptionsMonitor<ConnectionStrings>>().CurrentValue;

        services.AddDbContext<BahamDbContext>(options =>
        {
            options.UseNpgsql(
                connectionStrings.BahamDbContextConnection,
                x => x.UseNetTopologySuite()
            );
        });

        services.AddScoped<IUnitOfWork, BahamDbContext>();
        services.AddIdentityCore<User>()
        .AddRoles<Role>()
        .AddEntityFrameworkStores<BahamDbContext>();

        #region RegisterIdentityServices

        // services.AddScoped<IUserClaimsPrincipalFactory<User>, UserClaimService>();
        // services.AddScoped<UserClaimsPrincipalFactory<User, Role>, UserClaimService>();

        // services.AddScoped<IRoleManagerService, RoleManagerService>();
        // services.AddScoped<RoleManager<Role>, RoleManagerService>();

        // services.AddScoped<IRoleStoreService, RoleStoreService>();
        // services.AddScoped<RoleStore<Role, EShopDbContext, int, UserRole, RoleClaim>, RoleStoreService>();

        // services.AddScoped<IUserManagerService, UserManagerService>();
        // services.AddScoped<UserManager<User>, UserManagerService>();

        // services.AddScoped<IUserStoreService, UserStoreService>();
        // services.AddScoped<UserStore<User, Role, EShopDbContext, int, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>,
        //     UserStoreService>();

        // services.AddScoped<ISignInManagerService, SignInManagerService>();
        // services.AddScoped<SignInManager<User>, SignInManagerService>();

        #endregion

        return services;
    }
}
