
Beer erdingerBeer = new Beer("Erdinger", 3);

var coronaBeer = new Beer("Corona", 1.5m);

Console.WriteLine(erdingerBeer.Name);
Console.WriteLine(erdingerBeer.Name + " $ " + erdingerBeer.Price);
Console.WriteLine(erdingerBeer.GetInfo());


public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set;}

    public Beer(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string GetInfo()
    {
        return "Nombre: " + Name + ", Precio: $ " + Price;
    }
}