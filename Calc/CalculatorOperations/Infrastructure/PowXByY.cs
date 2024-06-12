namespace CalculatorCsharp;

public sealed class PowXByY : IPowXByY
{
    public double Invoke(double num1, double num2)
    {
        return Math.Pow(num1, num2);    
    }
}
