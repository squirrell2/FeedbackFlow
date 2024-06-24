using FeedbackFlow.Data.MigrationPostgreSql;
using FeedbackFlow.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FeedbackFlow.Api
{
    /// <summary>
    /// Методы расширения для настройки служб приложения
    /// </summary>
    public static class DiExtensions
    {
        public static IServiceCollection AddAppContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(nameof(FeedbackFlowContext)) ?? string.Empty;

            services.AddDbContext<FeedbackFlowContext>(opt =>
                opt
                    .UseNpgsql(connectionString, c => c.MigrationsAssembly(typeof(MigrationAssembly).Assembly.FullName)));

            return services;
        }

        public static IServiceCollection AddApplicationServises(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}

