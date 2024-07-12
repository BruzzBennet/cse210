using System;

// I added in the Goal Manager class a function that checks if all number required inputs are numbers, and if they aren't,
// It'll send a message until they put one
// Another thing I added was the chance to quit if somebody chose to insert a new goal by accident.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
            goalManager.Start();
    }
}