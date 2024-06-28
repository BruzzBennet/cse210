public class Word(string text){
    private string _text=text;
    private bool _isHidden=false;

    public string GetDisplayText(){
        return _text;
    }
    public void Hide(){
        int length=_text.Length;
        _text="";
        for (int i=0; i<length; i++){
            _text=_text+"_";
        }
        _isHidden=true;
    }
    public void Show(){

    }
    public bool isHidden(){
        return _isHidden;
    }
}