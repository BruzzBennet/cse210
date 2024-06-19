using System.Diagnostics;

public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public void addEntry(Entry entry){
        _entries.Add(entry);
    }
    public void displayAll(){
        foreach (Entry entry in _entries){
            entry.Display();
        }
        if (_entries.Count==0){
            Console.WriteLine("No journal entries available");
        }
    }
    public void SaveToFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entries in _entries){
                outputFile.WriteLine($"{entries._date},{entries._question},{entries._answer}");
            }            
        }
    }
    public void LoadFromFile(string filename){
        try {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string question = parts[1];
                string answer = parts[2];
                Entry journalentry = new Entry();
                journalentry._date=date;
                journalentry._question=question;
                journalentry._answer=answer;
                _entries.Add(journalentry);
            }
        }
        catch (FileNotFoundException){
            Console.WriteLine("Sorry, the file doesn't exist. Write the name correctly and don't forget the '.txt' at the end!");
        }
        
    }
}