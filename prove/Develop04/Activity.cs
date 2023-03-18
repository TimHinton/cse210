using System.Diagnostics;
using System.Threading;

public class Activity
{
    protected int _duration;
    protected string _desc;
    protected string _type;
    protected List<string> _prompts;
    protected string _prompt;


    public int DisplayStartingMessage()
    {
        Console.WriteLine($"You have selected a {_type} Activity.");

        Console.WriteLine($"\n{_desc}");

        Console.WriteLine("\nHow many seconds would you like to enjoy this activity?");
        _duration = int.Parse(Console.ReadLine());

        Console.Write($"Starting the {_type} activity in ...");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.Clear();

        return _duration;
    }


    public void DisplayEndingMessage()
    {
        displaySpinner(3);
        Console.Clear();

        Console.WriteLine("Thank you for taking time to participate in this activity.");
        displaySpinner(2);

        Console.WriteLine($"You have completed a {_type} activity for {_duration} seconds. Well done!");
        displaySpinner(3);
    }


    public string showPrompt()
    {
        Random randPrompt = new Random();
        int index = randPrompt.Next(0, _prompts.Count());
        string prompt = _prompts[index];

        Console.WriteLine(prompt);

        return prompt;
    }


    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int spinnerCounter = 0;
        
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;        
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
 
        Console.Write(" ");
    } 
 

    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
}