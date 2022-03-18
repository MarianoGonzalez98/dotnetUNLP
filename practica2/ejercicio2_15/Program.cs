/*
15. Escribir una función (método int Fib(int n)) que calcule el término n de la serie de
Fibonacci.
Fib(n) = 1, si n <=2
Fib(n) = Fib(n-1) + Fib(n-2), si n > 2
*/


int num;
Console.WriteLine("Escriba el termino n para obtener su numero de Fibronacci (finalice con -1)");
num= int.Parse(Console.ReadLine());
while (num!=-1 )
{
    Console.WriteLine($"Fibronacci({num}) = {Fib(num)}");
    num= int.Parse(Console.ReadLine());
}


int Fib(int n)
{
    if (n<=2) 
    {
        return 1;
    }
    else
    {
        return Fib(n-1) + Fib(n-2);
    }
}
