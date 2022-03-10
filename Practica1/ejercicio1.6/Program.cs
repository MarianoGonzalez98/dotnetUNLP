/*

6. Utilizar System.Console.ReadLine() para leer líneas de texto (secuencia de caracteres que
finaliza al presionar <ENTER>) por la consola. Por cada línea leída se debe imprimir la cantidad
de caracteres de la misma. El programa termina al ingresar la cadena vacía. (si st es una
variable de tipo string, entonces st.Length devuelve la cantidad de caracteres del string).

*/
string st= Console.ReadLine();
System.Console.WriteLine("100".Length);
Console.WriteLine(st=Console.ReadLine());
Console.WriteLine("----------------------");
do
{
    Console.WriteLine("El largo de la linea ingresada es: " + st.Length);
    st= Console.ReadLine();
} while (st.Length != 0);



Console.ReadLine();
