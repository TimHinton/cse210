using System;

class Program
{
    static void Main(string[] args)
    {
        string continu = "yes";


        // Do loop
        while (continu == "yes")
        {
            int int_guess = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 10);
            Console.Write("I have chosen a magic number.");
            
            while (int_guess != number)
            {
                Console.Write("What is your guess?");
                string guess = Console.ReadLine();

                int_guess = int.Parse(guess);

                if (int_guess == number)
                {
                    Console.WriteLine("Great work! You guessed the magic number.");
                    break;
                }

                else if (int_guess > number)
                {
                    Console.WriteLine("Lower...");
                }

                else
                {
                    Console.WriteLine("Higher...");
                }
            }

        Console.Write("Would you like to play again (yes/no) ? ");
        continu = Console.ReadLine();

        } while (continu == "yes");

    }
}