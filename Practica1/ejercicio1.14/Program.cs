/*

14. Escribir un programa que multiplique por 365 el número entero ingresado por el usuario desde
la consola. El resultado debe imprimirse en la consola dígito por dígito, separado por un espacio
comenzando por el dígito menos significativo al más significativo.

*/
Console.WriteLine("Ingrese un numero: ");
int num = int.Parse(Console.ReadLine());

string resultado = (num*365).ToString();

for (int i = 0; i < resultado.Length; i++)
{
    Console.Write(resultado[resultado.Length-i-1] + " ");
}

