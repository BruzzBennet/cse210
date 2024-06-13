using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.Write("What is your guess? ");
        string userInput1 = Console.ReadLine();
        int numberGuess = int.Parse(userInput1);
        if (numberGuess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (numberGuess < number)
        {
            Console.WriteLine("Higher");
        }
        do
        {
            Console.Write("What is your guess? ");
            userInput1 = Console.ReadLine();
            numberGuess = int.Parse(userInput1);
            if (numberGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (numberGuess < number)
            {
                Console.WriteLine("Higher");
            }
        } while (numberGuess != number);
        Console.WriteLine("You guessed it!");
    }
}