using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int int_perc = int.Parse(percentage);
        string grade;
        string add = "";

        if (int_perc >= 90)
        {
            grade = "A";
            if (int_perc < 93)
            {
                add = "-";
            }
        }

        else if (int_perc >= 80)
        {
            grade = "B";
            if (int_perc >= 97)
            {
                add = "+";
            }
            else if (int_perc < 93)
            {
                add = "-";
            }
        }

        else if (int_perc >= 70)
        {
            grade = "C";
            if (int_perc >= 97)
            {
                add = "+";
            }
            else if (int_perc < 93)
            {
                add = "-";
            }
        }

        else if (int_perc >= 60)
        {
            grade = "D";
            if (int_perc >= 97)
            {
                add = "+";
            }
            else if (int_perc < 93)
            {
                add = "-";
            }
        }

        else
        {
            grade = "F";
            if (int_perc >= 97)
            {
                add = "+";
            }
        }

        Console.WriteLine($"Grade: {grade}{add}");

        if (int_perc >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you needed at least a 70% to pass the class.");
        }

    }
}