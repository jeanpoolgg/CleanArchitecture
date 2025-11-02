var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2025,11,02,0,0,0)));

Action<string> show =  Console.WriteLine;
show("Hola");

Action<string> hi = name => Console.WriteLine($"Hola {name}");
hi("Héctor");
Action<int, int> add = (a, b) => show((a+b).ToString());
add(10, 20);

Func<int, int, int> mul = (a, b) => a * b;
show(mul(3, 4).ToString());
Func<int, int, string> mulString = (a, b) =>
{
    var res = a * b;
    return res.ToString();
};
show(mulString(10, 50));

// Función no pura
DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1);
}

Beer ToUpper(Beer beer)
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}

// Función pura
DateTime TomorrowPure(DateTime date)
{
    return date.AddDays(1);
}   

Beer ToUpperPure(Beer beer)
{
    return new Beer()
    {
        Name = beer.Name.ToUpper()
    };
}



public class Beer
{
    public string Name { get; set;}
}
