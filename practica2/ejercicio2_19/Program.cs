/*
19. Codificar el método Imprimir para que el siguiente código produzca la salida por consola que se observa.
Considerar que el usuario del método Imprimir podría querer más adelante imprimir otros datos, posiblemente de otros tipos pasando una cantidad distinta de parámetros cada vez que invoque el método.
Tip: usar params
*/
Imprimir(1,"casa",'A',3.4,DayOfWeek.Saturday);
Imprimir(1,2, "tres");
Imprimir();
Imprimir("-------------");

void Imprimir (params object[] vector)
{
    string st="";
    for (int i = 0; i < vector.Length; i++)
    {
        st+= vector[i]+" ";
    }
    Console.WriteLine(st);
}