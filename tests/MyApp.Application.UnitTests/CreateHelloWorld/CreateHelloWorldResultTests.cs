using MyApp.Application.CreateHelloWorld;
using MyApp.Domain.Enums;
using Xunit;

namespace MyApp.Application.UnitTests.CreateHelloWorld;

public class CreateHelloWorldResultTests
{
    [Fact]
    public void Should_Fill_All_Properties()
    {
        //arrange
        var result = new CreateHelloWorldResult
        {
            Id = Guid.NewGuid(),
            UserName = "test",
            Level = UserLevel.Admin
        };

        //act
        //assert
        foreach (var property in result.GetType().GetProperties())
            Assert.False(property.GetValue(result) == default, $"{property.DeclaringType}.{property.Name} is default value.");
    }
}