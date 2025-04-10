using CalculatorApp;
var calc = new Calculator();
Console.WriteLine($"Let's do some addition: 2 + 3 = {calc.Add(2, 3)}");
Console.WriteLine($"Let's do some subtraction: 3 - 1 = {calc.Subtract(3, 2)}");
Console.WriteLine($"Let's do some multiplication: 2 * 3 = {calc.Multiply(2, 3)}");
Console.WriteLine($"Let's do some division: 4 / 2 = {calc.Divide(4, 2)}");
Console.ReadKey();