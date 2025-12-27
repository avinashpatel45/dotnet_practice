using Data.ProductDbCotext;
using Microsoft.EntityFrameworkCore;

namespace Product.Configurations
{
    public static class Configurations
    {
        public static IServiceCollection AddDb(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("BaseURL");

            services.AddDbContext<ProductDbCotext>(options =>
                options.UseSqlServer(connectionString)
            );

            return services;
        }
    }
}
