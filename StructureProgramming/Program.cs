// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Infiere el tipo de dato
var num = 15;
var name = "Juan";

// === Arrays ===

int[] numeros = new int[5];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
numeros[3] = 4;
numeros[4] = 5;

var numbers = new int[5]{
    1,2,3,4,5
};

Console.WriteLine(numbers[2]);


// === Sentencias condicionales ===
var age = 12;

if(age > 60)
{
    Console.WriteLine("Es de la tercera edad");
}
else if(age > 18)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("Es menor de edad");
}

switch(age)
{
    case < 18:
        Console.WriteLine("Es menor de edad");
        break;
    case < 60:
        Console.WriteLine("Es mayor de edad");
        break;
    default:
        Console.WriteLine("Es de la tercera edad");
        break;
}

// === Sentencias de iteracion ===
var names = new string[]
{
    "Héctor", "Juan", "Pedro"
};

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// === Funciones ===

int res3 = Area(30);
int res1 = Area(20);

Console.WriteLine(res3);
Show("Arquitectura Limpia");
Bye();

int Area(int s)
{
    int res = s * s;
    return res;
}

void Show(string msg)
{
    Console.WriteLine(msg);
}

void Bye()
{
    Console.WriteLine("Adiós");
}

// === Ejemplo de programa con paradigma estructurado ===
int limit = 10;
var beers = new string[limit];
int iBeers = 0;
int op = 0;

do
{
    Console.Clear();
    ShowMenu();

    int option = int.Parse(Console.ReadLine() ?? "0");

    switch (option)
    {
        case 1:
            AddBeer();
            break;
        case 2:
            ListBeers();
            break;
        case 3:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }

} while (op != 3);


void ShowMenu()
{
    Console.WriteLine("1. Agregar cerveza");
    Console.WriteLine("2. Listar cervezas");
    Console.WriteLine("3. Salir");
    Console.Write("Seleccione una opción: ");
}

void AddBeer()
{
    if (iBeers < limit)
    {
        Console.Clear();
        Console.Write("Ingrese el nombre de la cerveza: ");
        string beerName = Console.ReadLine() ?? "";
        beers[iBeers] = beerName;
        iBeers++;
        Console.WriteLine("Cerveza agregada exitosamente.");
    }
    else
    {
        Console.WriteLine("Límite de cervezas alcanzado.");
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}

void ListBeers()
{
    Console.WriteLine("Cervezas almacenadas:");
    for (int i = 0; i < iBeers; i++)
    {
        Console.WriteLine($"{i + 1}. {beers[i]}");
    }
    Console.WriteLine("Presione Enter para continuar...");
    Console.ReadLine();
}