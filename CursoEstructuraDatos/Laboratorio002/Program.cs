// programa que sume los n primeros números

var n = 50;
var suma = 0;

for (var i = 1; i<=n; i++)
{
    suma = suma + i;
}

Console.WriteLine("El resultado es: "+suma.ToString());