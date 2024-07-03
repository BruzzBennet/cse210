public class WritingAssignment:Assignment{
    private string _title;

    public WritingAssignment(string SN, string T, string Ti): base(SN, T){
        _title=Ti;
    }
    
    public string GetWritingInformation(){
        return _title;
    }
}