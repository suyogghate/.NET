namespace Office;
public class OfficeBoy
{ 
    private static OfficeBoy _ref = null;
    private int _val;
    public int Val { 
        get { return _val; }
        set { _val = value; }
    }
    private OfficeBoy() { _val = 10; }
   
    public static OfficeBoy GetObject ()
    { 
        if (_ref == null)
            _ref = new OfficeBoy ();
        return _ref;
    }
}