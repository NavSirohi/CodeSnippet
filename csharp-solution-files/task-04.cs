using System;
class Building { public int Floors, Occupants; public double Area; public Building(int floors, double area, int occupants) { Floors = floors; Area = area; Occupants = occupants; } public void AreaPerPerson() => Console.WriteLine($"Area per person: {Area / Occupants:F2}"); }
class Program { static void Main() { Building house = new Building(2, 1800, 4), office = new Building(5, 10000, 50); Console.Write("House - "); house.AreaPerPerson(); Console.Write("Office - "); office.AreaPerPerson(); } }
