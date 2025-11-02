
using ObjectOrientedProgramming.Business;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000);
var delirium = new ExpiringBear("Delirium Tremens", 4.5m, 8.5m, new DateTime(2025, 12, 01), 350);

Drink drink = new Wine(500);
drink = new Beer("Corona", 2, 4, 330);

var service = new Service(100, 10);

ISalable[] concepts = [erdingerBeer, delirium, service];
Console.WriteLine(GetTotal(concepts));

SendSome(delirium);

var elements = new Collection<int>(3);
elements.Add(10);
elements.Add(20);
elements.Add(30);
elements.Add(40);
foreach (var item in elements.Get())
{
    Console.WriteLine(item);
}

var names = new Collection<string>(2);
names.Add("Héctor");
names.Add("Juan");
names.Add("Pedro");
foreach (var item in names.Get())
{
    Console.WriteLine(item);
}

var beers = new Collection<Beer>(2);
beers.Add(erdingerBeer);
beers.Add(delirium);
foreach (var item in beers.Get())
{
    Console.WriteLine(item.GetInfo());
}

void Show (Drink drink) =>  Console.WriteLine(drink.GetCategory());

void SendSome(ISend some)
{
    Console.WriteLine("Enviando...");
    some.Send();
}

decimal GetTotal(ISalable[] concepts)
{
    decimal total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
    }
    return total;
}   