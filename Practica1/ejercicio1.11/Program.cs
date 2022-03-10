/*

11. Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y
contestar las preguntas.

¿Qué se puede concluir respecto del operador de división “/” ?
-La division devuelve un numero entero si los 2 operandos son enteros. 
    Si al menos uno es decimal, devuelve un numero decimal.


¿Cómo funciona el operador + entre un string y un dato numérico?
-Concatena el numero al string.
*/


Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
