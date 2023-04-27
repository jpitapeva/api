using MyApp.Domain.Interfaces.Services;
using MyApp.Domain.Models;

namespace MyApp.Infrastructure.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public async Task<HelloWorldResponse> Create(string userName, int userLevel)
        {
            await Task.Delay(2000);
            return new HelloWorldResponse
            {
                UserId = Guid.NewGuid(),
                Level = userLevel,
                UserName = userName
            };
        }
    }
}