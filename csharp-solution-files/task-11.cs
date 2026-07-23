using System;
abstract class Employee { public string Name; protected Employee(string name) => Name = name; public abstract decimal Earnings(); }
class SalariedEmployee : Employee { decimal salary; public SalariedEmployee(string n, decimal s) : base(n) => salary = s; public override decimal Earnings() => salary; }
class HourlyEmployee : Employee { decimal rate; int hours; public HourlyEmployee(string n, decimal r, int h) : base(n) { rate = r; hours = h; } public override decimal Earnings() => Math.Min(hours, 40) * rate + Math.Max(hours - 40, 0) * rate * 1.5m; }
class CommissionEmployee : Employee { protected decimal sales, rate; public CommissionEmployee(string n, decimal s, decimal r) : base(n) { sales = s; rate = r; } public override decimal Earnings() => sales * rate; }
class BasePlusCommissionEmployee : CommissionEmployee { decimal baseSalary; public BasePlusCommissionEmployee(string n, decimal s, decimal r, decimal b) : base(n, s, r) => baseSalary = b; public override decimal Earnings() => baseSalary * 1.10m + base.Earnings(); }
class Program { static void Main() { Employee[] staff = { new SalariedEmployee("A", 1000), new HourlyEmployee("B", 20, 45), new CommissionEmployee("C", 10000, .1m), new BasePlusCommissionEmployee("D", 10000, .1m, 500) }; foreach (Employee e in staff) Console.WriteLine($"{e.Name}: {e.Earnings():C}"); } }
