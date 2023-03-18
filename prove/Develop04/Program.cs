using System;

class Program
{
    static void Main(string[] args)
    {
        string loop = " ";

        while (loop == " ")
        {
            string response = Menu();

            if (response == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
            }

            if (response == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
            }

            if (response == "3")
            {
                ListingActivity listing = new ListingActivity();
            }

            if (response == "4")
            {
                loop = "done";
            }
        }
        
    }


    static string Menu()
    {
        Console.Clear();

        // This will be the main menu for the program and returns the number choice
        Console.WriteLine("Which mindfulness activity would you like to enjoy? ");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. Quit");

        string response = Console.ReadLine();
        Console.Clear();

        return response;
    }

}