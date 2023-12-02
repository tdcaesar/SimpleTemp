using DigitalCaesar.SimpleTemp;
using FluentAssertions;

namespace SimpleTemp.UnitTests;

public class TemperatureValueTest
{
    [Fact]
    public void Constructor_Valid_Test()
    {
        Temperature testObject = new();
        testObject.Should().NotBeNull();
    }
}