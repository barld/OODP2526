public class Equation
{
    private double _a;
    private double _b;
    private double _c;

    public Equation(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override string ToString()
    {
        return $"{_a}x^2 + {_b}x + {_c} = 0";
    }
}