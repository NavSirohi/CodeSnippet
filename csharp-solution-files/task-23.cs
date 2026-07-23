using System;
class Program { static void Main() { double total = 0; for (int i = 1; i <= 4; i++) { Console.Write($"Number {i}: "); total += double.Parse(Console.ReadLine()!); } Console.WriteLine($"Average = {total / 4}"); } }
