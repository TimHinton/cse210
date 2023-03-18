public class ListingActivity : Activity
{
    private List<string> _items;

    public ListingActivity()
    {
        _type = "Listing";
        _desc = "This activity is to reflect on the good things in life. Think 'Count Your Many Blessings'.";

        _prompts = new List<string>();
        _items = new List<string>();

        PopulatePrompts();

        _duration = DisplayStartingMessage();

        _prompt = showPrompt();

        displayCountDown(5);

        GetItems();

        DisplayEndingMessage();
    }


    public void PopulatePrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    
    public void GetItems()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("");
        
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            _items.Add(item);
        }

        Console.WriteLine($"\nYou listed {_items.Count()}.");
    }



}