using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference=new Reference("Alma", 37,6);   
        Scripture re1=new Scripture(reference, "6 Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");
        re1.CreateList();
        string option="";

        while (option != "quit"){  
            Console.Clear();          
            Console.WriteLine($"{re1.GetDisplayText()}");
            Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
            option = Console.ReadLine();  
                if (re1.isCompletelyHidden()==true){
                    option="quit";
                }          
                else{
                    Random rnd = new Random();
                    int randomnumber=rnd.Next(2,5);
                    re1.HideRandomWords(randomnumber); 
                }                   
        }
    }
}