namespace CalculatorApp
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Can't divide by zero.");
            return (double)a / b;
        }

        public double Power(double a, double b) => Math.Pow(a, b);

        public double SquareRoot(double a)
        {
            if (a < 0) throw new ArgumentException("Cannot take square root of a negative number.");
            return Math.Sqrt(a);
        }
        public double Sin(double angleInRadians) => Math.Sin(angleInRadians);

        public double Cos(double angleInRadians) => Math.Cos(angleInRadians);

        public double Tan(double angleInRadians) => Math.Tan(angleInRadians);

        public double Log(double number)
        {
            if (number <= 0) throw new ArgumentException("Logarithm only defined for positive numbers.");
            return Math.Log(number);
        }

        public long Factorial(int number)
        {
            if (number < 0) throw new ArgumentException("Cannot calculate factorial of negative numbers.");
            long result = 1;
            for (int i = 1; i <= number; i++)
                result *= i;
            return result;
        }

        public double RadiansToDegrees(double radians) => radians * (180 / Math.PI);

        public double DegreesToRadians(double degrees) => degrees * (Math.PI / 180);

    }
}
