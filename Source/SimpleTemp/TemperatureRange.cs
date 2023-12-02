using System.Diagnostics;

namespace DigitalCaesar.SimpleTemp;

public class TemperatureRange
{
    public Decimal Minimum { get; }
    public Decimal Maximum { get; }

    private TemperatureRange(Decimal minimum, Decimal maximum)
    {
        if (minimum > maximum)
            throw new ArgumentOutOfRangeException(nameof(maximum), maximum,
                "The minimum value must be less than the maximum value.");
        
        Minimum = minimum;
        Maximum = maximum;
    }

    public static TemperatureRange Create(TemperatureScale scale)
    {
        TemperatureRange range = scale switch
        {
            TemperatureScale.Celsius => new TemperatureRange(-273, 273),
            TemperatureScale.Fahrenheit => new TemperatureRange(-459, 459),
            TemperatureScale.Kelvin => new TemperatureRange(0, 546),
            _ => throw new NotSupportedException("The value {scale} is not supported")
        };
        return range;
    }

    public bool IsValueInRange(Decimal value) => (value < Minimum & value > Maximum);
}