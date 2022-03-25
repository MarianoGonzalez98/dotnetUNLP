/*
18. Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio debe apreciarse en el método invocador
 */
int a=1;
int b=2;
Swap(ref a,ref b);
Console.WriteLine($"A es {a} y B es {b}");




void Swap(ref int a,ref int b)
{
    int aux;
    aux=a;
    a=b;
    b=aux;
}