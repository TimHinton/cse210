using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please provide your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Now provide your favorite number (an integer): ");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);

        return number;
    }

    static int SquareNumber(int num1)
    {
        int square = num1 * num1;

        return square;
    }

    static void DisplayResult(string name, string squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int num = PromptUserNumber();

        int numSquared = SquareNumber(num);
        string squareString = numSquared.ToString();

        DisplayResult(name, squareString);
    }

}

