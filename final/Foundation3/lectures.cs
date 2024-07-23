public class Lectures:Event{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity){
        _speaker=speaker;
        _capacity=capacity;
    }

    public override void FullDetails(){
        StandardDetails();
        Console.WriteLine($"Lecture by {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    public override void ShortDescription(){
        Console.WriteLine($"----Lecture----");
        Console.WriteLine($"'{_title}'");
        Console.WriteLine($"For: {_date}");
    }
}