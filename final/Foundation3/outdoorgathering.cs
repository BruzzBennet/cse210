public class OutdoorGathering:Event{
    private string _wheather;

    public void SetWheather(string wheather){
        _wheather=wheather;
    }

    public override void FullDetails(){
        StandardDetails();
        Console.WriteLine($"--Outdoor Gathering--");
        Console.WriteLine($"Wheather Forecast: {_wheather}");
    }

    public override void ShortDescription(){
        Console.WriteLine($"--Outdoor Gathering--");
        Console.WriteLine($"'{_title}'");
        Console.WriteLine($"For: {_date}");
    }
}