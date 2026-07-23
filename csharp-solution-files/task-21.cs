using System;
class Program { static void Main() { Console.Write("First number: "); double a = double.Parse(Console.ReadLine()!); Console.Write("Second number: "); double b = double.Parse(Console.ReadLine()!); Console.WriteLine($"Add: {a + b}\nSubtract: {a - b}\nMultiply: {a * b}\nDivide: {(b == 0 ? "undefined" : (a / b).ToString())}"); } }
