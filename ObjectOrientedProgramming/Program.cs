
using ObjectOrientedProgramming.Business;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000);
var delirium = new ExpiringBear("Delirium Tremens", 4.5m, 8.5m, new DateTime(2025, 12, 01), 350);

Drink drink = new Wine(500);
drink = new Beer("Corona", 2, 4, 330);

var service = new Service(100, 10);

ISalable[] concepts = [erdingerBeer, delirium, service];
Console.WriteLine(GetTotal(concepts));

SendSome(delirium);

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