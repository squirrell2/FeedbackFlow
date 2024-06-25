using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace FeedbackFlow.Api.Tests.Fixture;
public class ApiTestFactory : WebApplicationFactory<Startup>
{
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            // Настройка In-Memory БД для тестирования
            //services.AddDbContext<MyDbContext>(options =>
            //{
            //    options.UseInMemoryDatabase("InMemoryDbForTesting");
            //});

            // Можно добавить другие настройки сервиса, если требуется
        });

        return base.CreateHost(builder);
    }
}
