public class Reference(string book, int chapter, int versestart, int verseend=0){
    private string _book=book;
    private int _chapter=chapter;
    private int _versestart=versestart;
    private int _verseend=verseend;
    

    public string GetDisplayText(){
        if (_verseend == 0){
            return $"{_book} {_chapter}:{_versestart}";
        }
        else{
            return $"{_book} {_chapter}:{_versestart}-{_verseend}";
        }
    }
}
