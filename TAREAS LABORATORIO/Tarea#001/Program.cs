//Operaciones Básicas: 
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.

using System;
Console.WriteLine("Ingrese dos números para saber su suma, resta, multiplicación y división");
double a, b, c, d, e, f;
Console.Write("Ingrese el primer número: ");
a = int.Parse(Console.ReadLine());
Console.Write("ingrese el segundo número: ");
b = int.Parse(Console.ReadLine());
c = a + b;
Console.WriteLine("La suma es: {0}", c);
d = a - b;
Console.WriteLine("La resta es: {0}", d);
e = a * b;
Console.WriteLine("La múltiplicación es: {0}", e);
if (b == 0)
{
    Console.WriteLine("La división no es posible");
}
else
{
    f = a / b;
    Console.WriteLine("La división es: {0}", Math.Round(f, 2));
}
Console.ReadLine();

//Verificación de Número Par o Impar: 
//2) Solicita un número al usuario y determina si es par o impar. 

Console.WriteLine("Ingrese un número para saber si es par o impar");
Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.WriteLine("El número " + numero + " es par.");
}
else
{
    Console.WriteLine("El número " + numero + " es impar.");
}
Console.ReadLine();

//Área de un Triángulo: 
//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

Console.WriteLine("Ingrese la base y la altura de un triángulo para calcular el área");
Console.Write("Ingrese la base: ");
double ba = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura: ");
double h = double.Parse(Console.ReadLine());
double AT = (ba * h) / 2;
if (ba <= 0)
{
    Console.WriteLine("La base debe ser mayor a 0");
}
else if (h <= 0)
{
    Console.WriteLine("La altura debe ser mayor a 0");
}
else
    Console.WriteLine("El área del triángulo es: " + AT);
Console.ReadLine();

//Calculadora de Factorial: 
//4) Crea una función que calcule la factorial de un número. 

Console.WriteLine("Ingrese un número para calcular su factorial");
Console.Write("Ingrese el número: ");
long factor = long.Parse(Console.ReadLine());
long factorial = 1;
for (long i = 1; i <= factor; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + factor + " es: " + factorial);
Console.ReadLine();

//Número Primo: 
//5) Verifica si un número ingresado por el usuario es primo o no. 

Console.WriteLine("Ingrese un número para identificar si es primo o no");
Console.Write("Ingrese un número: ");
int primo = int.Parse(Console.ReadLine());
bool esPrimo = true;
if (primo <= 1)
{
    esPrimo = false;
}
else
{
    for (int p = 2; p <= primo / 2; p++)
    {
        if (primo % p == 0)
        {
            esPrimo = false;
            break;
        }
    }
}
if (esPrimo)
{
    Console.WriteLine("El número " + primo + " es primo.");
}
else
{
    Console.WriteLine("El número " + primo + " no es primo.");
}
Console.ReadLine();

//Inversión de Cadena: 
//6) Toma una cadena de texto y muestra su inversión. 

Console.WriteLine("Ingrese una cadena de texto para mostrar su inversión");
Console.Write("Ingrese la palabra o frase: ");
string cadena = Console.ReadLine();
string cadenaInvertida = "";
for (int ci = cadena.Length - 1; ci >= 0; ci--)
{
    cadenaInvertida += cadena[ci];
}
Console.WriteLine("La cadena invertida es: " + cadenaInvertida);
Console.ReadLine();

//Suma de Números Pares: 
//7) Calcula la suma de los números pares en un rango especificado por el usuario. 

Console.WriteLine("Ingrese los límites para determinar la suma de los pares dentro de ellos");
Console.Write("Ingrese el límite inferior del rango: ");
int limiteInferior = int.Parse(Console.ReadLine());
Console.Write("Ingrese el límite superior del rango: ");
int limiteSuperior = int.Parse(Console.ReadLine());
if (limiteSuperior <= limiteInferior)
{
    Console.WriteLine("Error: El límite superior debe ser mayor que el límite inferior.");
}
else
{
    int sumaPares = 0;
    for (int par = limiteInferior; par <= limiteSuperior; par++)
    {
        if (par % 2 == 0)
        {
            sumaPares += par;
        }
    }
    Console.WriteLine("La suma de los números pares en el rango es: " + sumaPares);
}
Console.ReadLine();

//Lista de Cuadrados: 
//8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

List<int> cuadrados = new List<int>();
for (int cua = 1; cua <= 10; cua++)
{
    int cuadrado = cua * cua;
    cuadrados.Add(cuadrado);
}
Console.WriteLine("Lista de cuadrados de los primeros 10 números naturales: ");
foreach (int cuadrado in cuadrados)
{
    Console.WriteLine(cuadrado);
}
Console.ReadLine();

//Contador de Vocales: 
//9) Cuenta el número de vocales en una cadena de texto. 

Console.WriteLine("Ingrese un texto para obtener el número de vocales");
Console.Write("Ingrese la palabra o texto: ");
string texto = Console.ReadLine().ToLower(); //(Así poder convertir en minúsculas)
int contadorA = 0;
int contadorE = 0;
int contadorI = 0;
int contadorO = 0;
int contadorU = 0;
for (int con = 0; con < texto.Length; con++)
{
    char caracter = texto[con];
    switch (caracter)
    {
        case 'a':
            contadorA++;
            break;
        case 'e':
            contadorE++;
            break;
        case 'i':
            contadorI++;
            break;
        case 'o':
            contadorO++;
            break;
        case 'u':
            contadorU++;
            break;
        case 'á':
            contadorA++;
            break;
        case 'é':
            contadorE++;
            break;
        case 'í':
            contadorI++;
            break;
        case 'ó':
            contadorO++;
            break;
        case 'ú':
            contadorU++;
            break;
        case 'ü':
            contadorU++;
            break;
    }
}
int vocales = contadorA + contadorE + contadorI + contadorO + contadorU;
Console.WriteLine("Número de vocales en la cadena:" + vocales);
Console.ReadLine();

//Números de la Serie Fibonacci: 
//10) Genera los primeros 10 números de la serie Fibonacci. 

Console.WriteLine("Los primeros 10 números de la serie Fobonacci");
for (int Fi = 0; Fi < 10; Fi++)
{
    Console.WriteLine(Fibonacci(Fi));
}
static int Fibonacci(int na)
{
    if (na == 0 || na == 1)
    {
        return na;
    }
    else
    {
        return Fibonacci(na - 1) + Fibonacci(na - 2);
    }
}
Console.ReadLine();

//Palíndromo: 
//12) Verifica si una palabra ingresada por el usuario es un palíndromo. 

Console.WriteLine("Ingrese una frase o palabra para saber si es un palíndromo");
Console.Write("Ingrese el texto: ");
string palindromo = Console.ReadLine().ToLower();
palindromo = palindromo.Replace(" ", "");
bool esPalindromo = EsPalindromo(palindromo);
if (esPalindromo)
{
    Console.WriteLine("La palabra \"" + palindromo + "\" es un palíndromo.");
}
else
{
    Console.WriteLine("La palabra \"" + palindromo + "\" no es un palíndromo.");
}
static bool EsPalindromo(string palindromo)
{
    for (int i = 0, j = palindromo.Length - 1; i < palindromo.Length / 2; i++, j--)
    {
        if (palindromo[i] != palindromo[j])
        {
            return false;
        }
    }
    return true;
}
Console.ReadLine();

//Generador de Tablas de Multiplicar: 
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

Console.WriteLine("Ingrese un número para generar su tabla de multiplicar hasta el mismo número");
Console.Write("Ingrese el número: ");
int numeromul = int.Parse(Console.ReadLine());
Console.WriteLine("Tabla de multiplicar del {0}:", numeromul);
for (int x = 1; x <= numeromul; x++)
{
    int resultado = numeromul * x;
    Console.WriteLine("{0} x {1} = {2}", numeromul, x, resultado);
}
Console.ReadLine();

//Cálculo del Área de un Círculo: 
//14) Pide el radio de un círculo al usuario y calcula su área. 

Console.WriteLine("Ingresar el radio de un círculo para calcular su área");
Console.Write("Ingrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());
double área = Math.PI * radio * radio;
Console.WriteLine("El área del círculo es: {0:F2}", área);
Console.ReadLine();

//Suma de Dígitos: 
//15) Toma un número entero y calcula la suma de sus dígitos. 

Console.WriteLine("Ingrese un número entero para calcular la suma de sus dígitos");
Console.Write("Ingrese un número entero: ");
int ne = int.Parse(Console.ReadLine());
int sumaDigitos = 0;
while (ne > 0)
{
    int digito = ne % 10;
    sumaDigitos += digito;
    ne /= 10;
}
Console.WriteLine("La suma de dígitos del número es: {0}", sumaDigitos);
Console.ReadLine();
