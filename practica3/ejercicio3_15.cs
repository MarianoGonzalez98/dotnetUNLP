/* 15. ¿Qué salida por la consola produce el siguiente código? */
int x = 0;
try
{
    Console.WriteLine(1.0 / x);
    Console.WriteLine(1 / x); //error aca: intento de division por 0
    Console.WriteLine("todo OK");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
/* ¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de los operandos? 

Esta permitido dividir un num flotante por 0
*/
