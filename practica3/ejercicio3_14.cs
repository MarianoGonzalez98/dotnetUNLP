/* 
14. Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base 10 a otra base realizando divisiones sucesivas. Por ejemplo para pasar 35 en base 10 a binario dividimos sucesivamente por dos hasta encontrar un cociente menor que el divisor, luego el resultado se obtiene leyendo de abajo hacia arriba el cociente de la última división seguida por todos los restos.
 */
Console.WriteLine(Base10a(35,2));


string Base10a(int num,int otraBase)
{
    string resultado="";
    Stack<int> pila= new Stack<int>();

    while (num>=otraBase) //mientras q el cociente no sea menor que el divisor
    {
        pila.Push(num % otraBase);
        num= num/otraBase;
    }
    pila.Push(num % otraBase);//para pushear el ultimo cociente
    while(pila.Count>0)
    {
        resultado += pila.Pop();
    }
    return resultado;
}
