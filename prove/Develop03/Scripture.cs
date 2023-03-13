public class Scripture
{
    private string _text;
    private string _reference;


    public Scripture(string[] wordList, string reference)
    {
        _reference = reference;

        foreach (string word in wordList)
        {
            _text = $"{_text} {word}";
        }
    } 

    public void DisplayText(string[] wordList)
    {        
        Console.WriteLine($"{_reference} -{_text}");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to hide words or type quit to end. ");
    }


    public void HideWords(string[] wordList, List<int> indexList)
    {
        int counter = 4;

        while (counter > 0)
        {
            int remainingIndex = (indexList.Count() - 1);
            Random choice = new Random();
            int number = choice.Next(0, remainingIndex);

            int index = indexList[number];
            wordList[index] = "____";
            indexList.RemoveAt(number);
            counter --;

            if (indexList.Count() == -1)
            {
                break;
            }
        }
        
    }


    public List<int> makeIndexList(string[] wordList)
    {
        List<int> indexList = new List<int>();
        int count = (wordList.Count() - 1);
        int counter = 0;
        while (counter <= count)
        {
            indexList.Add(counter);
            counter ++;
        }

        return indexList;
    }
}