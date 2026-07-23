using System;
class Program { static void Main() { Console.Write("Enter three numbers separated by spaces: "); string[] values = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries); Console.WriteLine($"Product = {double.Parse(values[0]) * double.Parse(values[1]) * double.Parse(values[2])}"); } }
