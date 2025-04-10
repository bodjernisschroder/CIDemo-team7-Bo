namespace CalculatorApp
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);

        // Advanced functions
        double Power(double a, double b);
        double SquareRoot(double a);

        // Trigonometry
        double Sin(double angleInRadians);
        double Cos(double angleInRadians);
        double Tan(double angleInRadians);

        // Logarithms and factorial
        double Log(double number);
        long Factorial(int number);

        // Unit conversions
        double RadiansToDegrees(double radians);
        double DegreesToRadians(double degrees);
    }

}