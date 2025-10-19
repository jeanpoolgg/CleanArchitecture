
using ObjectOrientedProgramming.Business;

Beer erdingerBeer = new Beer("Erdinger", 3, -2);
var delirium = new ExpiringBear("Delirium Tremens", 4.5m, 8.5m, new DateTime(2025, 12, 01));


Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
Console.WriteLine(delirium.GetInfo(1));
