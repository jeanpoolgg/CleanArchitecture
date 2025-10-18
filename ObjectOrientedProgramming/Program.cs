
Beer erdingerBeer = new Beer()
{
    Name = "Erdinger",
    Price = 3
};

var coronaBeer = new Beer();
coronaBeer.Name = "Corona";
coronaBeer.Price = 1.5m;

Console.WriteLine(erdingerBeer.Name);
Console.WriteLine(erdingerBeer.Name + " $ " + erdingerBeer.Price);
Console.WriteLine(erdingerBeer.GetInfo());


public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set;}

    public string GetInfo()
    {
        return "Nombre: " + Name + ", Precio: $ " + Price;
    }
}