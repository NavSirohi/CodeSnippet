using System;
class Program { static void Main() { Console.Write("First number: "); int a = int.Parse(Console.ReadLine()!); Console.Write("Second number: "); int b = int.Parse(Console.ReadLine()!); (a, b) = (b, a); Console.WriteLine($"After swap: {a}, {b}"); } }
