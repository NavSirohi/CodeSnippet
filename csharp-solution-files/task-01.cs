using System;

class Employee
{
    public string EmpName, EmpId, Address, MailId, MobileNo;
    protected decimal BasicPay;
    public Employee(string name, string id, string address, string mail, string mobile, decimal basicPay)
    { EmpName = name; EmpId = id; Address = address; MailId = mail; MobileNo = mobile; BasicPay = basicPay; }
    public void PrintPaySlip()
    {
        decimal da = BasicPay * .97m, hra = BasicPay * .10m, pf = BasicPay * .12m, club = BasicPay * .001m;
        Console.WriteLine($"{EmpName} ({GetType().Name})\nGross: {BasicPay + da + hra:C}\nNet: {BasicPay + da + hra - pf - club:C}");
    }
}
class Programmer : Employee { public Programmer(string n, string i, string a, string m, string p, decimal b) : base(n, i, a, m, p, b) { } }
class AssistantProfessor : Employee { public AssistantProfessor(string n, string i, string a, string m, string p, decimal b) : base(n, i, a, m, p, b) { } }
class AssociateProfessor : Employee { public AssociateProfessor(string n, string i, string a, string m, string p, decimal b) : base(n, i, a, m, p, b) { } }
class Professor : Employee { public Professor(string n, string i, string a, string m, string p, decimal b) : base(n, i, a, m, p, b) { } }
class Program { static void Main() { new Programmer("Asha", "E101", "Delhi", "asha@mail.com", "9999999999", 50000).PrintPaySlip(); } }
