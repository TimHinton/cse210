using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string proceed = "yes";
        List<int> numbers = new List<int>();
        string response;

        Console.WriteLine("Enter numbers to add to the list. Type 0 when finished. ");

        while (proceed == "yes")
        {
            Console.Write("Enter a number: ");
            response = Console.ReadLine();

            if (response == "0")
            {
                break;
            }

            int num = int.Parse(response);
            numbers.Add(num);
            
        }

        int total = 0;
        float avg;
        int largest = 0;
        int smallest = 100000;

        foreach (int number in numbers)
        {
            total += number;

            if (number > largest)
            {
                largest = number;
            }

            if (number < smallest && number >= 0)
            {
                smallest = number;
            }
        }

        int len = numbers.Count();
        avg = ((float)total / len);

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}