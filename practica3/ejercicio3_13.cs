/*
13. Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están bien balanceados.

Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena de entrada. Utilizar una pila para resolverlo. 

Los paréntesis de apertura de la entrada se almacenan en una pila hasta encontrar uno de cierre, realizándose entonces la extracción del último paréntesis de apertura almacenado. 

Si durante el proceso se lee un paréntesis de cierre y la pila está vacía, entonces la cadena es incorrecta.
Al finalizar el análisis, la pila debe quedar vacía para que la cadena leída sea aceptada, de lo contrario la misma no es válida. 
*/
if (Balanceado("(h(i(ka)) ")) Console.WriteLine("Balanceado");
else Console.WriteLine("No esta Balanceado");



bool Balanceado(string cadena)
{
    Stack<char> pila = new Stack<char>();
    for (int i = 0; i < cadena.Length; i++)
    {
        if(cadena[i]=='(')
        {
            pila.Push('(');
        }
        else if (cadena[i]==')')
        {
            if (pila.Count==0)
            {
                return false;
            }
            else
            {
                pila.Pop();
            }
        }
    }
    if (pila.Count!=0)
    {
        return false;
    }
    else
    {
        return true;
    }
}
