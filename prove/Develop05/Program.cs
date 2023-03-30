using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        Menu(player);
    }

    static void Menu(Player player)
    {
        string quitter = "";

        while (quitter != "quit")
        {
            Console.WriteLine("What would you like to do? (1 - 3)");
            Console.WriteLine("1. Make a new goal");
            Console.WriteLine("2. See your current goals");
            Console.WriteLine("3. Quit ");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                MakeGoal(player);
            } else if (answer == "2")
            {
                player.SeeGoals();
            } else
            {
                Console.WriteLine("Thank you for using this application. Have a good day.");
                quitter = "quit";
            }
        }
        
    }

    static void MakeGoal(Player player)
    {
        Console.WriteLine("\nWhat kind of goal would you like to make? (1 - 3)");
        Console.WriteLine("1. Event (single goal)");
        Console.WriteLine("2. Checklist (multiple steps)");
        Console.WriteLine("3. Repetitive goal (perform same task multiple times)");
        string goal = Console.ReadLine();

        if (goal == "1")
        {
            Event newGoal = new Event(player);
            string playerGoal = newGoal.AddGoalToPlayer();
            player.AddGoal(playerGoal);

        } else if (goal == "2")
        {
            Checklist newGoal = new Checklist(player);
        } else if (goal == "3")
        {
            Repeat newGoal = new Repeat(player);
        }
    }


}