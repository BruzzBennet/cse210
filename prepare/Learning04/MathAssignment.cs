public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string SN, string T, string TS, string P): base(SN, T){
        _textbookSection=TS;
        _problems=P;
    }
    
    public string GetHomeworkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}