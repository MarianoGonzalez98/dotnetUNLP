﻿/*

4. Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un
saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una
línea en blanco. Para ingresar un string desde el teclado utilizar
System.Console.ReadLine()

*/
Console.WriteLine("Ingrese su nombre:");
string nombre= Console.ReadLine();
string mensaje = (nombre != "") ? ("Hola "+nombre) : ("Hola mundo");
Console.WriteLine(mensaje);


Console.ReadLine();