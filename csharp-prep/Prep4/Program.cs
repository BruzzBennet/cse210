using System;

class Program
{
    static void Main(string[] args)
    {
        int sum=0;
        int largest=0;
        List<int> numberList;
        numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number=-1;
        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number!=0)
            {
                numberList.Add(number);
            }           
        } while (number != 0);
        foreach (int number1 in numberList)
        {
            sum=sum+number1;
        }
        foreach (int number1 in numberList)
        {
            if (number1 > largest){
                largest=number1;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numberList.Count}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}