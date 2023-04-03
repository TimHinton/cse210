using System;

class Program
{
    static void Main(string[] args)
    {
        Address Arizona = new Address("32 S. Center St", "Mesa", "Arizona", "US");
        Address Colorado = new Address("1350 S. Sheridan Ave", "Westminster", "CO", "US");
        Address Mexico = new Address ("3160 Via De Ventura", "Mexico City", "Mexico", "Mexico");

        Lecture yesMan = new Lecture("Yes", "The author himself will discuss the power of saying, 'Yes!'", "02/29/2024", "7:00 PM", Arizona.GetAddress(), "1,100", "Terrence Bundley");
        yesMan.DisplayShortDetails();
        yesMan.DisplayStandardDetails();
        yesMan.LectureDisplayFullDetails();
        Console.WriteLine("");


        Gathering familyReunion = new Gathering("The Hintons", "2023 Family Reunion", "8/13/23 - 8/15/23", "All the time", Colorado.GetAddress(), "Sunny skies");
        familyReunion.DisplayShortDetails();
        familyReunion.DisplayStandardDetails();
        familyReunion.GatheringDisplayFullDetails();
        Console.WriteLine("");


        Reception adamAndLacy = new Reception("Wedding Reception", "Wedding reception for Adam and Lacy", "4/3/24", "7:00 PM", Mexico.GetAddress(), "adamandlacy2024@yahoo.fake");
        adamAndLacy.DisplayShortDetails();
        adamAndLacy.DisplayStandardDetails();
        adamAndLacy.ReceptionDisplayFullDetails();
        Console.WriteLine("");
    }
}