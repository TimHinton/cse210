public class Event : Goal
{
    public Event(Player player)
    {
        _complete = false;
        _type = "event";

        // Creating event populates _name, _desc, _bonusPoints
        CreateEvent();

        player.AddGoal(AddGoalToPlayer());
    }



    public override int RecordEvent()
    {
        int pointReturn = CompleteGoal();

        return pointReturn;
    }

    public override bool IsComplete()
    {
        return _complete;
    }


    public override string AddGoalToPlayer()
    {
        // Saving the attributes in CSV type string
        string goal = $"{_type},{_name},{_desc},{_bonusPoints},{_complete}";

        return goal;
    }
}