public class TextList
{
    private int _reference;
    
    public TextList()
    {
    }    

    public string[] GetScrip(List<string> scripLists)
    {
        Random choice = new Random();
        int number = choice.Next(0, 4);

        string fullScripture = scripLists[number];
        
        string[] listReturn = fullScripture.Split(" ");

        _reference = number;

        return listReturn;
    }

    public int GetReference()
    {
        return _reference;
    }

    public List<string> PopulateList()
    {
        string filename = "textfile.txt";
        List<string> scripLists = new List<string>();

        // Use filename to retrieve the scripture texts
        string[] lines = System.IO.File.ReadAllLines(filename); 

        scripLists.AddRange(lines);

        return scripLists;
    }
}