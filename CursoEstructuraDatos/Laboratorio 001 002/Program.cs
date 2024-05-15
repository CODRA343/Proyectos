// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//// programa que sume los n primeros números

//var n = 50;
//var suma = 0;

//for (var i = 1; i<=n; i++)
//{
//    suma = suma + i;
//}

//Console.WriteLine($"La suma de los {n} primeros números es: {suma}");
Console.WriteLine("Ingrese un número para generar su tabla de multiplicar hasta el número 10");
Console.Write("Ingrese el número: ");
int numeromul = int.Parse(Console.ReadLine());
Console.WriteLine("Tabla de multiplicar del {0}:", numeromul);
for (int x = 1; x <= numeromul; x++)
{
    int resultado = numeromul * x;
    Console.WriteLine("{0} x {1} = {2}", numeromul, x, resultado);
}
Console.ReadLine();