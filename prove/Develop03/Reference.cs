public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;
    private List<string[]> _references;


    public Reference(int number)
    {
        string filename = "Referencefile.txt";

        // Use filename to retrieve the entries
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Iterate through each line, create list containing each word in scripture
        // and add this list to the _lists
        foreach (string line in lines)
        {
            string[] singleReference = line.Split(" ");

            _references.Add(singleReference);
        }

        string [] currentRefer = _references[number];

        if (currentRefer.Count() == 3)
        {
            _book = currentRefer[0];
            _chapter = currentRefer[1];
            _verse1 = currentRefer[2];
            _verse2 = "";
        }

        else
        {
            _book = currentRefer[0];
            _chapter = currentRefer[1];
            _verse1 = currentRefer[2];
            _verse2 = currentRefer[3];
        }
        
    }



    public string AddRefer()
    {
        if (_verse2 != "")
        {
            string refer = $"{_book} {_chapter}: {_verse1}";

            return refer;
        }

        else{
            string refer = $"{_book} {_chapter}: {_verse1} - {_verse2}";

            return refer;
        }
    }
}