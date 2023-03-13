public class TextList
{
    private List<string[]> _lists;
    private int _reference;
    
    public TextList()
    {

        string filename = "textfile.txt";

        // Use filename to retrieve the entries
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Iterate through each line, create list containing each word in scripture
        // and add this list to the _lists
        foreach (string line in lines)
        {
            string[] pieces = line.Split(" ");

            _lists.Add(pieces);
        }
    }

    public string[] GetScrip()
    {
        Random choice = new Random();
        int number = choice.Next(1, 5);

        string[] listReturn = _lists[number];

        _reference = number;

        return listReturn;
    }

    public int GetReference()
    {
        return _reference;
    }
}