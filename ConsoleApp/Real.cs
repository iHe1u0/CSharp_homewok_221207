using ConsoleApp;

public class Real : Number, Operation
{
    private double RealValue;
    private double _RealValue;
    public Real(double value)
    {
        _RealValue = value;
    }

    public override string Value
    {
        get => _RealValue.ToString();
        set => _RealValue = double.Parse(value);
    }

    public Number Add(Number n)
    {
        RealValue = double.Parse(n.Value);
        return new Real(_RealValue + RealValue);
    }

    public Number Divide(Number n)
    {
        RealValue = double.Parse(n.Value);
        if (RealValue == 0)
        {
            throw new DivideByZeroException();
        }
        return new Real(_RealValue / RealValue);
    }

    public Number Multiply(Number n)
    {
        RealValue = double.Parse(n.Value);
        return new Real(_RealValue * RealValue);
    }

    public Number Subtract(Number n)
    {
        RealValue = double.Parse(n.Value);
        return new Real(_RealValue - RealValue);
    }
}