using System.Collections.Generic;
using System.Dynamic;


namespace Library;
public class Books{
    private List<string> titles=new List<string>();
    public Books(){
        this.titles.Add("Ignited Minds");
        this.titles.Add("You can win");
        this.titles.Add("Let us c");
    }

    //indexer
    public string this[int index]{
        get{
         return this.titles[index];
        }
        set{
            this.titles[index]=value;
        }
    }
}