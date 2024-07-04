public class BreathingActivity:Activity{
    public BreathingActivity(){
        _name="Breathing";
        _description="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run(){
        DisplayStartingMessage();
        int time=_duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        time-=3;
        Console.WriteLine();
        while (time>0){
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(3);
            time-=3;
            Console.WriteLine();
            Console.Write("Breathe Out...");
            ShowCountDown(3);
            time-=3;
            Console.WriteLine();
        }       
        DisplayEndingMessage();
    }
}