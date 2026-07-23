using System;
class Program { static void Main() { Console.Write("Number: "); int n = int.Parse(Console.ReadLine()!); Console.WriteLine(n % 2 == 0 ? "Even" : "Odd"); } }
