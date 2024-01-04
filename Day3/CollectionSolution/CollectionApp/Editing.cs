using System.Collections;

namespace Editing;

public interface ISpellChecker
{ 
    ArrayList CheckSpelling (string word) ;
}


//Providers
public class EnglishSpellChecker:ISpellChecker
{
    public ArrayList CheckSpelling (string word) 
    {
        // return possible spelling suggestions}
        ArrayList words=new ArrayList();
        words.Add("person");
        words.Add("humanbeing");
        words.Add("animal");
        return words;
    }

}

class MarathiSpellChecker:ISpellChecker
{ 
 public ArrayList CheckSpelling (string word) 
    {
        // return possible spelling suggestions}
        ArrayList words=new ArrayList();
        words.Add("माणूस ");
        words.Add("व्यकती");
        words.Add("प्राणी");
        return words;
    }
}
 


 