using DigitalCaesar.SimpleTemp;
using FluentAssertions;

namespace SimpleTemp.UnitTests;

public class TemperatureValueTest
{
    private const decimal DefaultValue = 0;
    [Fact]
    public void Constructor_Default_Valid_Test()
    {
        // Arrange
        
        // Act
        Temperature testObject = new();
        
        // Assert
        testObject.Should().NotBeNull();
    }
    [Theory]
    [InlineData(0)]
    [InlineData(50)]
    [InlineData(100)]
    public void Constructor_Value_Valid_Test(Decimal testValue)
    {
        // Arrange
        
        // Act
        Temperature testObject = new(testValue);
        
        // Assert
        testObject.Should().NotBeNull();
    }
    [Theory]
    [InlineData(-1000)]
    [InlineData(1000)]
    public void Constructor_Value_Invalid_Test(Decimal testValue)
    {
        // Arrange
        
        // Act
        Temperature testObject = new(testValue);
        
        // Assert
        testObject.Should().NotBeNull();
    }
    

    [Fact]
    public void Method_Implicit_Value_Valid_Test()
    {
        // Arrange
        Temperature testObject = new();
        
        // Act
        Decimal result = testObject;
        
        // Assert
        result.Should().Be(DefaultValue);
    }
    
}