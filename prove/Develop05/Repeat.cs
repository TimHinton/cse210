public class Repeat : Goal
{
    private int _repeats;

    private int _numSoFar;

    public Repeat(Player player)
    {
        _complete = false;
        _numSoFar = 0;
        _type = "repeat";

        // Creating event populates _name, _desc, _bonusPoints
        CreateEvent();

        // Populating _repeats
        HowManyReps();

        player.AddGoal(AddGoalToPlayer());
    }

    public void HowManyReps()
    {
        Console.WriteLine("\nHow many times will be needed to complete this goal?");
        _repeats = int.Parse(Console.ReadLine());
    }


    public override int RecordEvent()
    {
        int pointReturn = 0;
        _numSoFar++;

        if (_numSoFar == _repeats)
        {
            Console.WriteLine($"Congratulations, you have completed this goal {_numSoFar} out of {_repeats} times!");
            pointReturn = CompleteGoal();
        }

        return pointReturn;
    }

    public override bool IsComplete()
    {
        return _complete;
    }


    /* public override void AddGoalToPlayer(Player player)
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete},{_repeats},{_numSoFar}";

        player.AddGoal(goal);
    } */

    public override string AddGoalToPlayer()
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete},{_repeats},{_numSoFar}";

        return goal;
    }
}