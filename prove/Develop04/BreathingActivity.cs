public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _type = "Breathing";
        _desc = "Controlling and focusing on breathing can help with relaxation. Begin by clearing your mind.";

        _duration = DisplayStartingMessage();

        Machinehead(_duration);

        DisplayEndingMessage();
    }

    public void Machinehead(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            string dot = ".";
            Console.Write($"\nBreathe in for ..");

            for (int i = 3; i > 0; i--)
            {

                Console.Write($"{dot}{i}");
                Thread.Sleep(1000);
                Console.Write("\b");

            }
            
            Console.Write("done.\n");
            
            Console.Write($"Breathe out for ..");

            for (int i = 3; i > 0; i--)
            {
                Console.Write($"{dot}{i}");
                Thread.Sleep(1000);
                Console.Write("\b");

            }
            
            Console.Write("done.\n");
        }
    }
}