public class Receptions:Event{
    private string _registration;

    public Receptions(string registration){
        _registration=registration;
    }

    public override void FullDetails(){
        StandardDetails();
        Console.WriteLine("----Reception----");
        Console.WriteLine($"RSVP email: {_registration}");
    }

    public override void ShortDescription(){
        Console.WriteLine($"----Reception----");
        Console.WriteLine($"'{_title}'");
        Console.WriteLine($"For: {_date}");
    }
}