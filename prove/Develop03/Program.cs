class Program
{
    static void Main(string[] args)
    {
        // Instantiate an empty Textlist, create list to use for all scriptures
        TextList newText = new TextList();
        List<string> scripLists = new List<string>();
        
        
        // Populate new list with all 5 scriptures, GetScrip will randomly choose 1 of the 5 to use and split text into individual word list
        scripLists = newText.PopulateList();
        string[] wordList = newText.GetScrip(scripLists);


        // Create reference object, use method to get the reference to the scripture chosen
        Reference scripReference = new Reference(newText.GetReference());


        // Finally, create Scripture object using chosen scripture with associated reference
        Scripture newScrip = new Scripture(wordList, scripReference.AddRefer());
        List<int> indexList = newScrip.makeIndexList(wordList);
        
        
        // Begin loop until user quits or all words are gone
        string loop = "";
        while (loop == "")
        {    
            Scripture loopScrip = new Scripture(wordList, scripReference.AddRefer());
            loopScrip.DisplayText(wordList);
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                loop = userInput;
            }
                
            else
            {
                Console.Clear();

                newScrip.HideWords(wordList, indexList);
            }
        }     
    }
}