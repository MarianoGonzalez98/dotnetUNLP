/*

13. Escribir un programa que calcule la suma de dos números reales introducidos por teclado y
muestre el resultado en la consola (utilizar double.Parse(st) para obtener el valor double a
partir del string st

*/
Console.WriteLine(@"Ingrese 2 numeros reales: (ingresar con ',')");

double num1= double.Parse(Console.ReadLine());
double num2= double.Parse(Console.ReadLine());
Console.WriteLine("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + (num1 + num2) );