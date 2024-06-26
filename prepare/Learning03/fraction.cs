using System.Diagnostics;

public class Fraction{
    private int _top;
    private int _bottom;
    public void Constructor(){
        _top=1;
        _bottom=1;
    }
    public void Constructor(int top){
        _top=top;
        _bottom=1;
    }
    public void Constructor(int top, int bottom){
        _top=top;
        _bottom=bottom;
    }
    public string GetFractionString(){
        string text=$"{_top}/{_bottom}";
        Console.WriteLine(text);
        return text;       
    }
    public double GetDecimalValue(){
        Console.WriteLine((double)_top/(double)_bottom);
        return (double)_top/(double)_bottom;
    }
}