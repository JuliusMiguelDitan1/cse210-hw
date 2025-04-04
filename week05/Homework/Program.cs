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
        WritingAssignment Write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(Write.Getsummary());
        Console.WriteLine(Write.GetWritingInformation());
    }
}