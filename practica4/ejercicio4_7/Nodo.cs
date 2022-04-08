/* 
7) Codificar la clase Nodo de un árbol binario de búsqueda de valores enteros. Un árbol binario de búsqueda no tiene valores duplicados y el valor de un nodo cualquiera es mayor a todos los valores de su subárbol izquierdo y es menor a todos los valores de su subárbol derecho.

Desarrollar los métodos:

1. Insertar(valor): Inserta valor en el árbol descartándolo en caso que ya exista.
2. GetInorden(): devuelve un ArrayList con los valores ordenados en forma creciente.
3. GetAltura(): devuelve la altura del árbol.
4. GetCantNodos(): devuelve la cantidad de nodos que posee el árbol.
5. GetValorMáximo(): devuelve el valor máximo que contiene el árbol.
6. GetValorMínimo(): devuelve el valor mínimo que contiene el árbol.
A modo de ejemplo, el siguiente código debe arrojar por consola la salida que se muestra.
 */
using System.Collections;
class Nodo
{
    int? valor;
    Nodo? hi;
    Nodo? hd;

    public Nodo(int num)
    {
        this.valor=num;
        this.hi=null;
        this.hd=null;
    }

    public void Insertar(int num)
    {
        if(num<this.valor)
        {
            if (this.hi != null)
            {
                this.hi.Insertar(num);
            }
            else
            {
                this.hi= new Nodo(num);
            }
        }
        else if (num>this.valor)
        {
            if (this.hd!= null)
            {
                this.hd.Insertar(num);
            }
            else
            {
                this.hd= new Nodo(num);
            }
        }
    }

    public ArrayList GetInOrder()
    {
        ArrayList a=new ArrayList();
        Stack<Nodo> pila= new Stack<Nodo>();
        Nodo? nodoAct= this;
        while ( pila.Count!=0 || nodoAct!=null)
        {
            while (nodoAct!= null)
            {
                pila.Push(nodoAct);
                nodoAct = nodoAct.hi;
            }
            if (pila.Count!=0)
            {
                Nodo n = pila.Pop();
                a.Add(n.valor);
                nodoAct=n.hd;
            }
        }
        return a;
    }
}
//2. GetInorden(): devuelve un ArrayList con los valores ordenados en forma creciente.
