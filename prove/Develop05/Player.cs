public class Player
{
    private string _name;
    private int _points;
    private List<string> _goals;


    public Player()
    {
        _name = "user";
        _points = 0;
        List<string> _goals = new List<string>();
    }

    public Player(string name, int points, List<string> goals)
    {
        _name = name;
        _points = points;
        _goals = goals;
    }

    public void AddGoal(string goal)
    {
        this._goals.Add(goal);
    }

    public void SaveGame()
    {
        string filename = "Saves.cs";

        // Use filename to retrieve the player info
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_points);
            outputFile.WriteLine(_goals);
        }
    }

    public void LoadGame()
    {
        string filename = "Saves.cs";
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        int points = int.Parse(lines[0]);
        List<string> goals = new List<string>();
        goals.Add(lines[1]);
        
        Player player = new Player("user", points, goals);
    }

    public void SeeGoals()
    {
        int counter = 1;

        if (this._goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals at this time. Why not make one?");
        } else
        {
            foreach(string goal in _goals)
            {
                string[] stringGoal = goal.Split(",");
                string completed = stringGoal[4];
                string isCompleted = "Incomplete";

                if (completed == "true")
                {
                    isCompleted = "Completed";
                }

                Console.WriteLine($"{counter}) {stringGoal[1]}, {stringGoal[2]} ");
                Console.WriteLine($"    {isCompleted}\n\n");

                counter ++;
            }
        }
        
    }
}