public class Prompt
{
    public List<string> _prompts = new List<string>();

    public void Populate()
    {
        _prompts.Add("What is one of the best things that happened today?");
        _prompts.Add("What was one of the hardest things that happened today?");
        _prompts.Add("What would you have done differently today?");
        _prompts.Add("Did you do any service?");
        _prompts.Add("What blessings did you notice today?");
    }

    public string RandoString()
    {
        Random rando = new Random();
        int index = rando.Next(0, _prompts.Count);

        string phrase = _prompts[index];

        return phrase;
    }
        
}