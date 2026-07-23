using System;
class Program { static void Main() { Console.Write("Enter text: "); string s = (Console.ReadLine() ?? "").Replace(" ", "").ToLower(); char[] c = s.ToCharArray(); Array.Reverse(c); Console.WriteLine(s == new string(c) ? "Palindrome" : "Not a palindrome"); } }
