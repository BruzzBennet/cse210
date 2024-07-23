public class Running:Activity{

    public Running(string date, int length, double distance):base(date,length){
        _distance=distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min) - Distance {Math.Round(_distance,2)} km, Speed {Math.Round(GetSpeed(),2)} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }
}