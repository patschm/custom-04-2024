using ACME.Database.EntityFramework.Repositories;
using ACME.Domain.Catalog.Repositories;
using ACME.Domain.Reviews.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ACME.Database.EntityFramework;

public static class DependencyInjection
{
    public static IServiceCollection AddEntityFrameworkRepositories(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("Database")));

        services.AddScoped<IProductReadRepository, ProductRepository>();
        services.AddScoped<IProductWriteRepository, ProductRepository>();
        services.AddScoped<IReviewReadRepository, ReviewRepository>();
        services.AddScoped<IReviewWriteRepository, ReviewRepository>();

        return services;
    }
}
