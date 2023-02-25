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
            int num_guess = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.WriteLine("I have chosen a magic number between 1 and 100.");
            
            while (int_guess != number)
            {
                num_guess ++ ;
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();

                int_guess = int.Parse(guess);

                if (int_guess == number)
                {
                    Console.WriteLine("Great work! You guessed the magic number.");
                    Console.WriteLine($"It took you {num_guess} guesses.");
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

    Console.WriteLine("Thank you for playing.");
    }
}