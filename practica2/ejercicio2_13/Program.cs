/*

13. Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
noviembre, octubre …, enero)
c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al
nombre de un mes
Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses

*/
string mesIngresado;
Console.WriteLine("Ingrese el nombre de un mes: ");
mesIngresado= Console.ReadLine();
bool corresponde=false;
for (Meses m = Meses.diciembre; m >= Meses.enero; m--)
{
    if ((mesIngresado.ToLower()) == m.ToString())
    {
        corresponde=true;
        break;
    }
}
if (corresponde)
{
    Console.WriteLine($"La palabra{mesIngresado} corresponde a un mes.");
}
else
{
    Console.WriteLine($"La palabra {mesIngresado} NO corresponde a un mes.");
}


for (Meses m = Meses.diciembre; m >= Meses.enero; m--)
{
    Console.WriteLine(m);
}


enum Meses
{
    enero,febrero,marzo,abril,
    mayo,junio,julio,agosto,
    septiembre, octubre, noviembre,
    diciembre
}
