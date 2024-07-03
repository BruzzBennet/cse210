public class Assignment{
    protected string _studentName;
    protected string _topic;

    public Assignment(string SN, string T){
        _studentName=SN;
        _topic=T;
    }
    
    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}