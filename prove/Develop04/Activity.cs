public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        bool quit=false;
        while (!quit){
            Console.Write("How long, in seconds, would you like your session? ");
            string duration = Console.ReadLine();
            try{
                 _duration=int.Parse(duration);
                 quit=true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert a number");
            }
        }
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        int time=seconds;
        time=time*2;
        while (time>0){
            foreach(string a in animation){
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
                time--;;
            }
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        int time=seconds;
        for (int i=0;i<time;i++){
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}