using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        int pass = 0;
        Console.Write("What is your grade? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        if (grade >= 90)
        {
            letter = "A";
            pass = 1;
        }
        else if (grade >= 80)
        {
            letter = "B";
            pass = 1;
        }
        else if (grade >= 70)
        {
            letter = "C";
            pass = 1;
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write($"Your grade is: {letter}. ");
        if (pass == 1)
        {
            Console.Write("Congratulations, you passed!");
        }
    }
}