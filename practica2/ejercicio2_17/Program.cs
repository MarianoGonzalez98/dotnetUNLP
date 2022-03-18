/*
16. Escribir una función (método int Fac(int n)) que calcule el factorial de un número n
pasado al programa como parámetro por la línea de comando
a) Definiendo una función no recursiva
b) Definiendo una función recursiva
c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional
ternario)

17. Ídem. al ejercicio 16.a) y 16.b) pero devolviendo el resultado en un parámetro de salida
void Fac(int n, out int f)

*/


DateTime time =  DateTime.Now;
time.


int num;
Console.WriteLine("Escriba un numero (finalice con -1)");
num= int.Parse(Console.ReadLine());
while (num!=-1 )
{
    Console.WriteLine($"El factorial de {num} es {Fac(num)} {Fac2(num)} {Fac3(num)}");
    num= int.Parse(Console.ReadLine());
}



void Fac(int n, out int resultado)
{
    if (n<1) resultado=1;
    else
    {   
        Fac
        resultado= n*
        return n* Fac(n-1);
    }
}

int Fac2(int n)
{
    int num=1;
    for (int i = 2; i <= n; i++)
    {
        num*=i;
    }
    return num;
}

int Fac3 (int n) => (n<1) ? 1 : n * Fac3(n-1);
