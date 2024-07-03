using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Matt Bennet","Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2= new MathAssignment("Bryce Burnes", "Multiplication","7.3","8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Matt Lopez","History of Europe","World History");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}