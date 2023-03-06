using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstF = new Fraction();
        Fraction secondF = new Fraction(5);
        Fraction thirdF = new Fraction(3, 4);
        Fraction fourthF = new Fraction(1/3);

        string ans1 = GetFractionString(firstF);
        Console.WriteLine(ans1);

        double ans2 = GetDecimalValue(secondF);
        Console.WriteLine(ans2);

        int ans3 = thirdF.GetTop();
        Console.WriteLine(ans3);

        int ans4 = fourthF.GetBot();
        Console.WriteLine(ans4);
    }

    static string GetFractionString(Fraction frac)
    {
        int top = frac.GetTop();
        int bot = frac.GetBot();
        string ans = $"{top}/{bot}";

        return ans;
    }

    static double GetDecimalValue(Fraction frac)
    {
        int top = frac.GetTop();
        int bot = frac.GetBot();

        double ans = top/bot;

        return ans;
    }
}