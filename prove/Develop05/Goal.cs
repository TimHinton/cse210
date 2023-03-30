public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _desc;
    protected int _bonusPoints;
    protected bool _complete;

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public int CompleteGoal()
    {
        // Makes _complete true
        _complete = true;

        return _bonusPoints;
    }

    public void CreateEvent()
    {
        Console.WriteLine("\nWhat would you like to name this goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("Please provide a short description of the goal. ");
        _desc = Console.ReadLine();

        Console.WriteLine("How many bonus points are to be awarded upon completion of the entire goal?");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    /*public virtual void AddGoalToPlayer(Player player)
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete}";

        player.AddGoal(goal);
    } */
    public virtual string AddGoalToPlayer()
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete}";

        return goal;
    }
}