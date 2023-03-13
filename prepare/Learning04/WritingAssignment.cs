public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }


    public string GetParentSummary()
    {
        string summary = GetSummary();

        return summary;
    }

    public void GetWritingInformation()
    {
        string parentSummary = GetParentSummary();
        string author = GetName();
        string secondLine = $"{_title} by {author}";

        Console.WriteLine(parentSummary);
        Console.WriteLine(secondLine);
    }
}