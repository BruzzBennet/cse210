using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Blue Lagoon 150","Blueville","Riversmouth","United Nations");
        Address address2 = new Address("Riversmouth 1000","Joyville","Joyland","United Nations");
        Address address3 = new Address("Bellavista 300","Lovegreen","Gran Rey","Grandes Reyes");

        List<Event> events = new List<Event>();

        Lectures event1=new Lectures("John Williams",100);
        event1.SetTitle("How to be happy");
        event1.SetDescription("A world renown psychologist teaches us how to find happiness besides each challenge in our lives.");
        event1.SetDate("10/05/2026");
        event1.SetAdress(address1);
        events.Add(event1);

        Receptions event2=new Receptions("greatstories<@joy.com");
        event2.SetTitle("How to make a great story");
        event2.SetDescription("Experienced filmmakers teach what has helped them reach success with their stories");
        event2.SetDate("07/10/2028");
        event2.SetAdress(address2);
        events.Add(event2);

        OutdoorGathering event3=new OutdoorGathering();
        event3.SetWheather("Windy");
        event3.SetTitle("Beach Yoga");
        event3.SetDescription("Complete relaxation with yoga and the sound of the sea.");
        event3.SetDate("11/02/2025");
        event3.SetAdress(address3);
        events.Add(event3);

        foreach (Event activity in events){
            activity.StandardDetails();
            Console.WriteLine();
            activity.ShortDescription();
            Console.WriteLine();
            activity.FullDetails();
            Console.WriteLine();
        }
    }
}