/*

12. Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
consola. Para obtener el entero desde un string st utilizar int.Parse(st).


*/
Console.WriteLine("Ingrese un numero entero: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Sus divisores son: ");

for (int i = 1; i <= num; i++)
{
    if (num%i==0)
    {
        Console.Write(i+" ");
    }
}