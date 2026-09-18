using CustomerSupport.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CustomerSupport.Infrastructure.Extensions
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,string connectionString)
        {
            /*
             public CustomerSupportDbContext(DbContextOptions<CustomerSupportDbContext> options)
             */
            services.AddDbContext<CustomerSupportDbContext>(options =>
            {
                //UseSqlServer=> database provider for SQL Server
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
