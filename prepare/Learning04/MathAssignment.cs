public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string problems, string textbook) : base(name, topic)
    {
        _problems = problems;
        _textbookSection = textbook;
    }


    public string GetParentSummary()
    {
        string summary = GetSummary();

        return summary;
    }

    public void GetHomeworkList()
    {
        string parentSummary = GetParentSummary();
        string homework = $"Section {_textbookSection} Problems {_problems}";

        Console.WriteLine(parentSummary);
        Console.WriteLine(homework);
    }
}