// See https://aka.ms/new-console-template for more information
Calculator calc = new Calculator();
int sum = calc.Add(5, 7);
int product = calc.Multiply(3, 4);
int deleno = calc.Divide(8, 3);
int minus = calc.Subtract(12, 4);

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Deleno: {deleno}");
Console.WriteLine($"Minus: {minus}");