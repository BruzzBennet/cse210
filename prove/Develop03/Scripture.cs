public class Scripture(Reference reference, string text)
{
    private string _reference=text;
    private Reference _ref1=reference;
    private List<Word> _words=new List<Word>();
    private string quote;

    public void CreateList(){
        string[] lines=_reference.Split(" ");
        foreach (String line in lines){
            Word line_to_word = new Word(line);
            _words.Add(line_to_word);
        } 
    }
    public string GetDisplayText()
    {                     
        quote="";
        foreach(Word word in _words){
            quote=quote+" "+word.GetDisplayText();
        }
        return $"{_ref1.GetDisplayText()}: {quote}";
    }
    public void HideRandomWords(int words)
    {        
            foreach(Word word in _words){
                Random rnd = new Random();
                int randomnumber=rnd.Next(1,3);
                if (randomnumber==1 && words>0){
                    if (!word.isHidden()){
                        word.Hide();
                        words-=1;
                    }                
                }      
            }                
    }
    public bool isCompletelyHidden()
    {
        int w_list=_words.Count();
        int h_list=0;
        foreach(Word word in _words){
            if (word.isHidden()){
                h_list+=1;
                if (h_list==w_list)
                {
                    return true;
                }
            }                         
        }
        return false;             
    }
}