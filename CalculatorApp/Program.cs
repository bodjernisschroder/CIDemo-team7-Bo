using CalculatorApp;

var calc = new Calculator();

Console.WriteLine($"Let's do some addition: 2 + 3 = {calc.Add(2, 3)}");
Console.WriteLine($"Let's do some subtraction: 3 - 1 = {calc.Subtract(3, 2)}");
Console.WriteLine($"Let's do some multiplication: 2 * 3 = {calc.Multiply(2, 3)}");
Console.WriteLine($"Let's do some division: 4 / 2 = {calc.Divide(4, 2)}");
Console.WriteLine($"Time to power up: 4^4 = {calc.Power(4, 4)}");
Console.WriteLine($"The squareroot of 12 = {calc.SquareRoot(12)}");

while (true)
{
    Console.WriteLine("\nWelcome to this entirely useless console calculator!");
    Console.WriteLine("Please choose what you'd like to play with:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Power");
    Console.WriteLine("6. Squareroot");

    Console.ReadKey();
}

