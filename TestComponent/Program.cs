IF f = new F();
var S = new S(f);


// ---------------------
public class S
{
    private readonly IF _f;

    public S(IF f)
    {
        _f = f;
    }

    public void Do()
    {
        _f.Some();
    }
}

// ----------------------
public interface IF 
{
    public void Some();
}

// ----------------------
public class F : IF
{
    public void Some()
    {
        // CODIGO
    }
}

// ----------------------
public class F2 : IF
{
    public void Some()
    {
        // CODIGO
    }
}