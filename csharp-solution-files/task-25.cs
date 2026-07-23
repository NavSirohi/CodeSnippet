using System;
class Program { static void Main() { Console.Write("First integer: "); int a = int.Parse(Console.ReadLine()!); Console.Write("Second integer: "); int b = int.Parse(Console.ReadLine()!); Console.WriteLine(a == b ? "Numbers are equal." : "Numbers are not equal."); } }
