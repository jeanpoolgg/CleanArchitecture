Console.WriteLine(Tomorrow());
Console.WriteLine(TomorrowPure(new DateTime(2025, 11, 02, 00, 00, 00)));

var beer = new Beer()
{
    Name = "Delirium Tremens"
};

Console.WriteLine(ToUpperPure(beer).Name);
Console.WriteLine(beer.Name);


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
