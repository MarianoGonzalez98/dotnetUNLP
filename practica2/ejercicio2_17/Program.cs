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


int num;
Console.WriteLine("Escriba un numero (finalice con -1)");
num= int.Parse(Console.ReadLine());
while (num!=-1 )
{
    int resultado1;
    int resultado2;
    Fac(num,out resultado1);
    Fac2(num,out resultado2);
    Console.WriteLine($"El factorial de {num} es {resultado1} {resultado2} {Fac3(num)}");
    num= int.Parse(Console.ReadLine());
}



void Fac(int n, out int resultado)
{
    if (n<1) resultado=1;
    else
    {   
        Fac(n-1,out resultado);
        resultado= n* resultado;
    }
}

void Fac2(int n, out int resultado)
{
    resultado=1;
    for (int i = 2; i <= n; i++)
    {
        resultado*=i;
    }
}

int Fac3 (int n) => (n<1) ? 1 : n * Fac3(n-1);