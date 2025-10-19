
using ObjectOrientedProgramming.Business;

Beer erdingerBeer = new Beer("Erdinger", 3, -2, 1000);
var delirium = new ExpiringBear("Delirium Tremens", 4.5m, 8.5m, new DateTime(2025, 12, 01), 350);

Drink drink = new Wine(500);
Show(drink);
drink = new Beer("Corona", 2, 4, 330);
Show(drink);
Show(erdingerBeer);

void Show (Drink drink) =>  Console.WriteLine(drink.GetCategory());