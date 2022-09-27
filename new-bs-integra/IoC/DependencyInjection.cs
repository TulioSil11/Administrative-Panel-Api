using Microsoft.EntityFrameworkCore;
using new_bs_integra.Models;
using new_bs_integra.Repositores;
using new_bs_integra.Repositores.Interfaces;
using new_bs_integra.Security;
using new_bs_integra.Security.Interfaces;
using new_bs_integra.Services;
using new_bs_integra.Services.Interfaces;
using new_bs_integra.Utilites;

namespace new_bs_integra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services,
                                                          IConfiguration configuration)
        {
            services.AddScoped<IToken, Token>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<CriptyKey>();
            services.AddScoped<ModelContext>();

            return services;
        }

        public static IServiceCollection ReadArchiversConfiguration(this IServiceCollection services,
                                                                         IConfiguration configuration)
        {
            services.AddDbContext<ModelContext>(options => options
            .UseOracle(configuration.GetConnectionString("DefaultConnection"), o => o.UseOracleSQLCompatibility("11")));

            services.Configure<TokenConfiguration>(configuration.GetSection("TokenConfiguration"));

            services.Configure<Jwt_Key>(configuration.GetSection("Jwt"));

            return services;
        }
    }
}
