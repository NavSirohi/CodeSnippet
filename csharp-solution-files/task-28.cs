using System;
class Program { static void Main() { Console.Write("Year: "); int year = int.Parse(Console.ReadLine()!); bool leap = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0); Console.WriteLine(leap ? "Leap year" : "Not a leap year"); } }
