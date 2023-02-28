using System;

class Program
{
    static void Main(string[] args)
    {
        Job
        job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Recess Rocks";
        job1._startYear = "2020";
        job1._endYear = "2023";
        //job1.ShowJobInfo();

        Job
        job2 = new Job();
        job2._jobTitle = "Being a crab";
        job2._company = "Insta";
        job2._startYear = "1985";
        job2._endYear = "2020";

        Resume
        res1 = new Resume();
        res1._name = "Howie the Crab";
        res1._jobs.Add(job1);
        res1._jobs.Add(job2);

        res1.Display();
    }

}