public class Entry{
    public string _date;
    public string _question;
    public string _answer;

    public void Display(){
        Console.WriteLine($"{_date} {_question} {_answer}");
    }
}