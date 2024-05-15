// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Un programa que pida un número que indique que es par o impar

//Declarar variables
Console.WriteLine("==== Programa que determina si es par o impar ====");
Console.Write("INGRESE UN NUMERO ENTERO:");
var numeroRecibido = Console.ReadLine();
var numero = int.Parse(numeroRecibido);
var esPar = false;

//Resolver
if (numero % 2 == 0)
{
    esPar = true;
}
// Mostrar resultados
Console.WriteLine(esPar ? "Es par" : "Es impar");
Console.ReadLine();


//var i = 10;
//
//var indice = 1;
//
//do
//{
//    Console.WriteLine(indice);
//    indice++;
//} while (indice <= i);

//while (indice <= i)
//{
//    Console.WriteLine(indice);
//    indice++;
//}

//for (var j = 1; j <=i; j++)
//{
//  Console.WriteLine(j);
//}

//var mensaje = i >= 4 ? "El número es mayor a 4!" : "El número es menor a 4!";

//if (i >= 4)
//{
//    //positiva
//    Console.WriteLine("El número es mayor a 4!");
//}
//else
//{
//    //Negativo
//    Console.WriteLine("El número es menor a 4!");
//}

//Declarar variables
Console.WriteLine("==== Programa que determina si es par o impar ====");
Console.Write("INGRESE UN NUMERO ENTERO: ");
var numeroRecibido = Console.ReadLine();
var numero = int.Parse(numeroRecibido);
var esPar = false;

//Resolver
if (numero % 2 == 0)
{
    esPar = true;
}
// Mostrar resultados
Console.WriteLine(esPar ? "Es par" : "Es impar");
Console.ReadLine();