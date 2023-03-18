public class ReflectionActivity : Activity
{
    private List<string> _questions;

    public ReflectionActivity()
    {
        _type = "Reflection";
        _desc = "The intent of this activity is to reflect on times in your life when you have demonstrated strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _questions = new List<string>();
        _prompts = new List<string>();

        PopulatePrompts();

        _duration = DisplayStartingMessage();

        _prompt =  showPrompt();

        AskQuestions(_duration);

        DisplayEndingMessage();
    }

    public void PopulatePrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }


    public void AskQuestions(int duration)
    {
        
        Console.WriteLine("Take several seconds to reflect on the following questions regarding this experience.");
        Console.WriteLine("When you have an experience in mind, press enter to continue.");
        string waiting = Console.ReadLine();

        displayCountDown(5);
        
        
        while (duration > 5)
        {
            // Get a random question by generating random index number
            Random rando = new Random();
            int choice = rando.Next(0, (_questions.Count() -1));

            // Display the question and wait 5 seconds
            Console.WriteLine("\n    {0}", _questions[choice]);
            displaySpinner(5);

            // Removing used question from the copied list
            _questions.RemoveAt(choice);

            duration -= 5;
        }

        Random random = new Random();
        int lastChoice = random.Next(0, (_questions.Count() -1));

        // Finish off the remaining time
        switch (duration)
        {
            case 1:
                Console.WriteLine("\n    {0}", _questions[lastChoice]);
                displaySpinner(1);
                break;
            case 2:
                Console.WriteLine("\n    {0}", _questions[lastChoice]);
                displaySpinner(2);
                break;
            case 3:
                Console.WriteLine("\n    {0}", _questions[lastChoice]);
                displaySpinner(3);
                break;
            case 4:
                Console.WriteLine("\n    {0}", _questions[lastChoice]);
                displaySpinner(4);
                break;
        }


    }
}