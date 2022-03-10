/*

17. Utilizar el operador ternario condicional para establecer el contenido de una variable entera con
el menor valor de otras dos variables enteras.


*/
Console.Write("Ingrese la primer variable entera:");
int var1= int.Parse(Console.ReadLine());
Console.Write("Ingrese la segunda variable entera:");
int var2= int.Parse(Console.ReadLine());
int varMenor= (var1<var2) ? var1 : var2;
Console.WriteLine($"La menor variable es : {varMenor}");


