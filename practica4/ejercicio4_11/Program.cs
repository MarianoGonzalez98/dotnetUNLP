// 11) Qué salida produce en la consola el siguiente programa?

object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o); //se considera sobrecarga object en tiempo de compilacion(no se puede convertir implicitamente object a int)
s.Procesar((dynamic)o, o); //en tiempo de ejecucion se considera sobrecarga entera
s.Procesar((dynamic)o, (dynamic)o); //es una sobrecarga mas especifica
s.Procesar(o, (dynamic)o);//o es tipo objeto y no se puede convertir a int implicitamente
s.Procesar(5, 5); //va por el metodo mas especifico
class Sobrecarga
{
    public void Procesar(int i, object o)
    {
        Console.WriteLine($"entero: {i} objeto:{o}");
    }
    public void Procesar(dynamic d1, dynamic d2)
    {
        Console.WriteLine($"dynamic d1: {d1} dynamic d2:{d2}");
    }
}

