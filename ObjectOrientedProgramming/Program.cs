
Beer erdingerBeer = new Beer("Erdinger", 3, -2);

Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(erdingerBeer.SAlcohol);

public class Beer
{
    // Campos
    private decimal _alcohol;

    // Propiedades
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public decimal Alcohol
    {
        get { return _alcohol; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            _alcohol = value;
        }
    }

    public string SAlcohol
    {
        get
        {

            return "Alcohol: " + _alcohol.ToString();
        }
        
    }

    public Beer(string name, decimal price, decimal alcohol)
    {
        Name = name;
        Price = price;
        Alcohol = alcohol;
    }

    public string GetInfo()
    {
        return "Nombre: " + Name + ", Precio: $ " + Price + ", Alcohol: " + Alcohol;
    }
}