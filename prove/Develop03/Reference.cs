public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;



    public Reference(int number)
    {
        string filename = "Referencefile.txt";

        // Use filename to retrieve the entries
        string[] lines = System.IO.File.ReadAllLines(filename);

        
        // Get the reference being used and split it into separate strings
        // to be used to create object attributes
        string currentRefer = lines[number];
        
        string[] splitReference = currentRefer.Split(" ");


        // Set attributes for instance
        if (splitReference.Count() == 3)
        {
            _book = splitReference[0];
            _chapter = splitReference[1];
            _verse1 = splitReference[2];
            _verse2 = "";
        }

        else
        {
            _book = splitReference[0];
            _chapter = splitReference[1];
            _verse1 = splitReference[2];
            _verse2 = splitReference[3];
        }
        
    }



    public string AddRefer()
    {
        if (_verse2 == "")
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