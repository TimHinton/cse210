using System;

class Program
{
    static void Main(string[] args)
    {
        TextList newText = new TextList();
        string[] newWordList = newText.GetScrip();

        Reference scripReference = new Reference(newText.GetReference());

        Scripture newScrip = new Scripture(newWordList, scripReference.AddRefer());
        
        
        string loop = "";

        while (loop == "")
            
            newScrip.DisplayText();
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                loop = userInput;
            }
                
            else
            {
                Console.Clear();

                newScrip.HideWords(newWordList);

            
            }
            
    }
}