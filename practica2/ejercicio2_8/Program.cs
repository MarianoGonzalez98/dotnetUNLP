/*8. 
Escribir un programa que reciba una lista de nombres como parámetro e imprima por consola un saludo personalizado para cada uno de ellos.
a) utilizando la sentencia for
b) utilizando la sentencia foreach

*/
for (int i = 0; i < args.Length; i++)
{
    if (args[i].ToLower()=="mariano" )
    {
        Console.WriteLine("Hola genio!");
    }
    else if (args[i].ToLower()=="julia")
    {
        Console.WriteLine("Hola bella!!!");
    }
    else
        Console.WriteLine($"Hola {args[i]}");
}

Console.WriteLine("Hello, World!----------");

foreach (var item in args)
{
    if (item.ToLower()=="mariano" )
    {
        Console.WriteLine("Hola genio!");
    }
    else if (item.ToLower()=="julia")
    {
        Console.WriteLine("Hola bella!!!");
    }
    else
        Console.WriteLine($"Hola {item}");
}