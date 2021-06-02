using AZ204.Demo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AZ204.Demo.Api.Extensions
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddCatalogContext(this IServiceCollection services, string connectionString)
        {
            return services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CatalogContext>(contextOptions => 
                {
                    contextOptions.UseSqlServer(connectionString, 
                        serverOptions => 
                        {
                            serverOptions.MigrationsAssembly(typeof(Startup).Assembly.FullName);
                        });
                });
        }
    }
}
