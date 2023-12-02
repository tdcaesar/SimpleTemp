namespace DigitalCaesar.SimpleTemp;

public class Temperature
{
    private const Decimal DefaultValue = 0;
    private const TemperatureScale DefaultScale = TemperatureScale.Celsius;
    public Decimal Value { get; }
    public TemperatureScale Scale { get; }

    public Temperature(Decimal value = DefaultValue, TemperatureScale scale = DefaultScale)
    {
        Scale = scale;
        Value = value;
    }

    public static implicit operator Decimal(Temperature value) => value.Value;

    public override string ToString() => $"{Value}\u00b0{(char)Scale}";
}