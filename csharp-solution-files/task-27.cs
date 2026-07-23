using System;
class Program { static void Main() { Console.Write("Number: "); double n = double.Parse(Console.ReadLine()!); Console.WriteLine(n > 0 ? "Positive" : n < 0 ? "Negative" : "Zero"); } }
