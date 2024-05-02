//Un programa que pida un número que indique que es par o impar

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