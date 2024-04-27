/*se desea calcular la distancia recorrida (m) por un móvil que tiene velocidad constante
(m/s) durante un tiempo T (sg), considerar que es un MRU (movimiento rectilíneo uniforme) */
//double d, v, t;
//Console.Write("ingrese la velocidad constante: ");
//v = int.Parse(Console.ReadLine()); 
//Console.Write("ingrese el tiempo : "); 
//t = int.Parse(Console.ReadLine()); 
//d = v * t;
//Console.Write("la distancia es: {0}", d); 
//Console.ReadLine();

using System;

double a, b, c, d, e, f;
Console.Write("Ingrese el primer número: ");
a = int.Parse(Console.ReadLine()); 
Console.Write("ingrese el segundo número: "); 
b = int.Parse(Console.ReadLine());
c = a + b;
Console.WriteLine("La suma es: {0}", c);

if (a >= b)
{
    d = a - b;
    Console.WriteLine("La resta es: {0}", d);
}
else
{
    d = b - a;
    Console.WriteLine("La resta es: {0}", d);
}

e = a * b;
Console.WriteLine("La múltiplicación es: {0}", e);


if (b == 0)
{
   Console.WriteLine("La división no es posible");
}
else
{
    f = a/b;
    Console.WriteLine("La división es: {0}", Math.Round(f, 2));
}

Console.ReadLine();

//Console.WriteLine("=====Programa Factorial=====");
//Console.WriteLine("Ingrese un número para calcular el factorial:");
//int numero = int.Parse(Console.ReadLine());

//double factorial = 1;

//if (numero < 0)
//{
//    Console.WriteLine("No se puede calcular el factorial su número es negativo.");
//}
//else
//{
//    for (int i = 1; i <= numero; i++)
//    {
//        factorial *= i;
//    }

//    Console.WriteLine($"El factorial de {numero} es: {factorial}");
//    Console.Read();
//}