using System;

class Program
{
    static void Main(string[] args)
    {
        Running runningSession = new Running(30, (decimal)3.5);
        Cycling cyclingSession = new Cycling(120, 25);
        Swimming swimmingSession = new Swimming(20, 8);

        runningSession.GetSummary();
        cyclingSession.GetSummary();
        swimmingSession.GetSummary();
    }
}