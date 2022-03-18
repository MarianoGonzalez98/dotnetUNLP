/*

14. Implementar un programa que muestre todos los números primos entre 1 y un número natural
dado (pasado al programa como argumento por la línea de comandos). Definir el método bool
EsPrimo(int n) que devuelve true sólo si n es primo. Esta función debe comprobar si n es
divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d)
devuelve la raíz cuadrada de d)

*/
int num;

Console.WriteLine("Ingrese un numero, finalice con -1");
num= int.Parse(Console.ReadLine());
while (num!= -1)
{
    if (EsPrimo(num))
    {
        Console.WriteLine($"El numero {num} es primo");
    }
    else
    {
        Console.WriteLine($"El numero {num} NO es primo");
    }
    Console.WriteLine("Ingrese un numero, finalice con -1");
    num= int.Parse(Console.ReadLine());
}

bool EsPrimo(int n)
{
    bool ok=true;
    for (int i = n-1; i >= 2 ; i--)
    {
        if (n%i == 0)
        {
            ok=false;
            break;
        }
    }

    return ok;
}
