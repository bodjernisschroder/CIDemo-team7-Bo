namespace CalculatorApp
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
        double Power(double a, double b);
        double SquareRoot(double a);
    }
}