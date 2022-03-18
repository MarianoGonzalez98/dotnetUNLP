// See https://aka.ms/new-console-template for more information

//2. Sea el siguiente código:
object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);
/*
El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas
variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la consola no sea “Z Z”?

porque en la linea < o2 = "Z"; > , la variable o2 va a tomar una nueva referencia y descartar la anterior

??

*/


Console.WriteLine("Hello, World!");