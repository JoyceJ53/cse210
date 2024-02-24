using System;

class Program
{
    static void Main(string[] args)
    {
        // assignment super class
        Console.WriteLine();
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // math sub class
        Console.WriteLine();
        MathAssignment assignmentmath = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignmentmath.GetSummary());
        Console.WriteLine(assignmentmath.GetHomeworkList());

        // writing sub class
        Console.WriteLine();
        WritingAssignment assignmentwriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignmentwriting.GetSummary());
        Console.WriteLine(assignmentwriting.GetWritingInformation());
        Console.WriteLine();
    }
}