public class Checklist : Goal
{
    private int _itemPoints;
    private int _completed;
    private List<string[]> _activities;


    public Checklist(Player player)
    {
        _complete = false;
        _activities = new List<string[]>();
        _type = "checklist";
        _completed = 0;
        
        // Creating event populates _name, _desc, _bonusPoints
        CreateEvent();

        Console.WriteLine("How many points would you like to assign to each individual item upon completion?");
        _itemPoints = int.Parse(Console.ReadLine());

        GetActivities();

        player.AddGoal(AddGoalToPlayer());
    }


    public void GetActivities()
    {
        // User inputs activities to go on the checklist. Adds to _activities attr. until user types done
        string answer = "";
        
        while (answer != "done")
        {
            Console.WriteLine("\nList the activities to be completed as part of the checklist (Type 'done' to complete the list). ");
            answer = Console.ReadLine();
        
        
            string isDone = "false";
            string[] activity = {answer, isDone};

            _activities.Add(activity);
        }
        Console.WriteLine("");
    }


    public void DisplayChecklist()
    {
        // Iterates through the checklist of activities and will display [x] {activity} or [ ] {activity} as appropriate

        string done = "[x]";
        string notdone = "[ ]";

        foreach (string[] activity in _activities)
        {
            if (activity[1] == "yes")
            {
                Console.WriteLine($"{done} {activity[0]}");
            } else {
                Console.WriteLine($"{notdone} {activity[0]}");
            }
        }
    }

    public override int RecordEvent()
    {
        int counter = 1;

        foreach (string[] activity in _activities)
        {
            Console.WriteLine($"{counter}. {activity[0]}");
            counter++;
        }
        
        Console.WriteLine("What is the number for the activity you completed? ");
        int itemComplete = int.Parse(Console.ReadLine());

        int itemIndex = itemComplete - 1;
        _activities[itemIndex][1] = "yes";

        _completed ++;
        if (_completed == counter)
        {
            Console.WriteLine("Congratulations, you have completed this entire checklist!");
        }

        return _itemPoints;
    }

    public override bool IsComplete()
    {
        // Returns current value of _complete as bool
        return _complete;
    }


    /* public override void AddGoalToPlayer(Player player)
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete},{_itemPoints},{_completed},{_activities}";

        player.AddGoal(goal);
    } */

    public override string AddGoalToPlayer()
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete},{_itemPoints},{_completed},{_activities}";

        return goal;
    }
}