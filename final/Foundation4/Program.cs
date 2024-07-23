using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running activity1= new Running("3 Nov 2024",30,3);
        activities.Add(activity1);
        Cycling activity2= new Cycling("4 Sep 2025",25,15);
        activities.Add(activity2);
        Swimming activity3=new Swimming("6 Oct 2026",45,10);
        activities.Add(activity3);

        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}