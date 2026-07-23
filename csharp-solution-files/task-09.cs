using System;
class Food { public Food() { Console.WriteLine("Food"); } }
class Fruit : Food { public Fruit() { Console.WriteLine("Fruit"); } }
class Apple : Fruit { public Apple() { Console.WriteLine("Apple"); } }
class Program { static void Main() { _ = new Apple(); } }
