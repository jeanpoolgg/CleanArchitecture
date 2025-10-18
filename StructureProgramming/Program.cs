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