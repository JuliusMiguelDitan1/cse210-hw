using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assign = new Assignment("Burnice Calivan", "Deravitive");
        Console.WriteLine(Assign.Getsummary());
        MathAssignment Math = new MathAssignment("Burnice Calivan", "Deravitive", "7.3", "9-10");
        Console.WriteLine(Math.GetHomeworkList());
        Console.WriteLine();
        Assignment A1 = new Assignment("Mary Waters", "European History");
        Console.WriteLine(A1.Getsummary());
        WritingAssignment Write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(Write.GetWritingInformation());
    }
}