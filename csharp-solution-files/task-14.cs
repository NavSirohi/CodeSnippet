using System;
interface RegisterForExams { void Register(); }
class Student : RegisterForExams { public void Register() => Console.WriteLine("Student registered for exams."); }
class Employee : RegisterForExams { public void Register() => Console.WriteLine("Employee registered for exams."); }
class Program { static void RegisterCandidate(RegisterForExams candidate) => candidate.Register(); static void Main() { RegisterCandidate(new Student()); RegisterCandidate(new Employee()); } }
