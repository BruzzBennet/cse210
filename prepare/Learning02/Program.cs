using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle="Software Engineer";
        job1._company="Apple";
        job1._startYear=2012;
        job1._endYear=2021;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle="Backend Developer";
        job2._company="Microsoft";
        job2._startYear=2021;
        job2._endYear=2024;
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name="Bruce Bennet";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}