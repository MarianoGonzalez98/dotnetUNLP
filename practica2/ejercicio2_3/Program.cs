

/* 3. Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
¿Qué hace realmente?

Tiene un ; al final de la linea del while, queda en una iteracion permanente como si fuera while(1<=10){};

*/

int sum = 0;
int i = 1;
while (i <= 10);
{
    sum += i++;
}

Console.WriteLine(sum);
