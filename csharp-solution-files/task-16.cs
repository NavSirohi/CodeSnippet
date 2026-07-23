using System;
abstract class Student { public abstract void TakeExam(); }
class PhdStudent : Student { public override void TakeExam() => Console.WriteLine("PhD student gives a final defense presentation."); }
class GradStudent : Student { public override void TakeExam() => Console.WriteLine("Graduate student gives a written paper."); }
class Program { static void Main() { Student[] students = { new PhdStudent(), new GradStudent() }; foreach (Student student in students) student.TakeExam(); } }
