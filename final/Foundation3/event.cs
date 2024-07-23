public abstract class Event(){
    protected string _title;
    protected string _description;
    protected string _date;
    protected Address _address;

    public void SetTitle(string title){
        _title=title;
    }

    public void SetDescription(string description){
        _description=description;
    }

    public void SetDate(string date){
        _date=date;
    }

    public void SetAdress(Address address){
        _address=address;
    }

    public void StandardDetails(){
        Console.WriteLine($"---'{_title}'---");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Event date: {_date}");
        Console.WriteLine($"Address: {_address.Display()}");
    }

    public abstract void FullDetails();

    public abstract void ShortDescription();
}