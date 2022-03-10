/*
1. Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos
WriteLine() y Write() de la clase System.Console ¿Cómo funciona el método Readkey() de
la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo”
haciendo una pausa entre palabra y palabra esperando a que el usuario presione una tecla para
continuar
*/


// Diferencia entre los métodos WriteLine() y Write() de la clase System.Console:
// WriteLine() imprime un dato realizando al finalizar un salto de linea, Write() no.

//¿Cómo funciona el método Readkey() de la misma clase?
// Lee una tecla pulsada por el usuario y la guarda en un objeto ConsoleKeyInfo. La tecla se puede imrimir en pantalla o no, dependiendo de si el metodo recibe como parametro true o false.


// Escribir un programa que imprima en la consola la frase “Hola Mundo” haciendo 
//  una pausa entre palabra y palabra esperando a que el usuario presione una tecla para continuar

//test cambio github
Console.Write("Hola ");
Console.ReadKey(true);
Console.WriteLine("mundo");


Console.ReadLine();
