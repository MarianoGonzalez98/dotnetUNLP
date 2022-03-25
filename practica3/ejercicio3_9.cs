//9. Señalar errores de compilación y/o ejecución en el siguiente código

object obj = new int[10];
dynamic dyn = 13;
Console.WriteLine(obj.Length); //error de compilacion porque el tipo Objeto no tiene definido Length
Console.WriteLine(dyn.Length); //error de ejecucion porque el tipo int no tiene definido Length
