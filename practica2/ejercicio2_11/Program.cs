/*
11. ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las palabras (una por línea) de una frase ingresada por consola por el usuario

El metodo split devuelve un array de strings con las cadenas que se encuentren entre el o los caracteres pasados como parametros.

*/
string frase;
Console.WriteLine("Ingrese una frase");
frase= Console.ReadLine();

string[] palabras = frase.Split(' ');

foreach (var item in palabras)
{
    Console.WriteLine(item);
}
