using DigitalCaesar.SimpleTemp;
using FluentAssertions;

namespace SimpleTemp.UnitTests;

public class TemperatureRangeTest
{
    [Theory]
    [InlineData(TemperatureScale.Celsius)]
    [InlineData(TemperatureScale.Fahrenheit)]
    [InlineData(TemperatureScale.Kelvin)]
    public void Method_Create_Valid_Test(TemperatureScale testValue)
    {
        // Arrange
        // Act
        TemperatureRange testObject = TemperatureRange.Create(testValue);
        // Assert
        testObject.Should().NotBeNull();
    }
    
    
    
    //TODO: test for scale not supported
    //TODO: test for minimum over maximum
    //TODO: test values
}