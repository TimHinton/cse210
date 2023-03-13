public class Scripture
{
    private string _text;
    private string _reference;
    private int _countShowing;
    private List<int> _remainingWords;

    public Scripture(string[] wordList, string reference)
    {
        foreach (string word in wordList)
        {
            _text = $"{_text} {word}";
        }

        _countShowing = wordList.Count();
        int count = (wordList.Count() - 1);
        _reference = reference;

        int counter = 0;
        while (counter <= count)
        {
            _remainingWords.Add(counter);
            counter ++;
        }
    } 

    public void DisplayText()
    {
        Console.WriteLine($"{_reference} : {_text}");
        Console.WriteLine("Press Enter to hide words or type quit to end. ");
    }


    public void HideWords(string[] wordlist)
    {
        int counter = 5;


        while (counter > 0)
        {
            int remainingIndex = (wordlist.Count() - 1);
            Random choice = new Random();
            int number = choice.Next(0, remainingIndex);

            wordlist[number] = "____";
            _remainingWords.RemoveAt(number);
            counter --;
            _countShowing --;

            if (_countShowing == 0)
            {
                break;
            }
        }
        
    }
}