public class Swimming:Activity{
    protected int _laps;
 
    public Swimming(string date, int length, int laps):base(date,length){
        _laps=laps;
    }

    public override double GetDistance()
    {
        _distance=_laps*50/100;
        return _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {Math.Round(GetDistance(),2)} km, Speed {Math.Round(GetSpeed(),2)} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }
}