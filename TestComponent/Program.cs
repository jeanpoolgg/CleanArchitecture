
public interface IA
{
    void MethodA();
}

public interface IB
{
    void MethodB();
}

public interface IC
{
    void MethodC();
}

public class A : IA
{
    private readonly IB _b;

    public A(IB b)
    {
        _b = b;
    }

    public void MethodA()
    {
    }
}

public class B : IB
{
    private readonly IC _c;

    public B(IC c)
    {
        _c = c;
    }

    public void MethodB()
    {
    }
}

public class C : IC
{
    private readonly IA _a;

    public C(IA a)
    {
        _a = a;
    }

    public void MethodC()
    {
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("El programa compila correctamente.");
    }
}
