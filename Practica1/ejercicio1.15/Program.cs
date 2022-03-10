/*

15. Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es bisiesto si
es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto debe ser divisible
por 400.

*/


Console.WriteLine("Ingrese un año: ");
int anio = int.Parse((Console.ReadLine()));

if (((anio%4 == 0 ) && (anio%100 != 0))
|| ((anio % 100 == 0) && (anio%400 ==0)))
{
    Console.WriteLine($"El anio {anio} es bisiesto");
}
else
{
    Console.WriteLine($"El anio {anio} no es bisiesto");
}

