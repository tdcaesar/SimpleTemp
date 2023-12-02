namespace DigitalCaesar.SimpleTemp;

public class Temperature
{
    private const Decimal DefaultValue = 0;
    private const TemperatureScale DefaultScale = TemperatureScale.Celsius;
    private Decimal Value { get; }
    private TemperatureScale Scale { get; }

    public Temperature(Decimal value = DefaultValue, TemperatureScale scale = DefaultScale)
    {
        Scale = scale;
        TemperatureRange range = TemperatureRange.Create(scale);
        if (range.IsValueInRange(value))
            Value = value;
        else
            throw new ArgumentOutOfRangeException(nameof(value),
                "The value must be within range for the temperature scale.");
    }

    public static implicit operator Decimal(Temperature value) => value.Value;

    public override string ToString() => $"{Value}\u00b0{(char)Scale}";
}