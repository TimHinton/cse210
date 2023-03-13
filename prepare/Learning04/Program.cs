using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment sammy = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(sammy.GetSummary());
        Console.WriteLine("");

        MathAssignment robby = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        robby.GetHomeworkList();
        Console.WriteLine("");

        WritingAssignment mary = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        mary.GetWritingInformation();
        Console.WriteLine("");
    }
}