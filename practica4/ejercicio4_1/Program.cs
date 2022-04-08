/*
1) Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI. Escribir un algoritmo que permita al usuario ingresar en una consola una serie de datos de la forma Nombre,Documento,Edad<ENTER>. Una vez finalizada la entrada de datos, el programa debe imprimir en la consola un listado con 4 columnas de la siguiente forma:
*/
List<Persona> lista = new List<Persona>();


System.Console.WriteLine("Ingrese los datos de la forma datos de la forma Nombre,Documento,Edad<ENTER>. Finalice con  \"zzz\"");
string? input=System.Console.ReadLine();
while (input!="zzz")
{
    lista.Add(ingreso(input));
    System.Console.WriteLine("Ingrese Nombre,Documento,Edad<ENTER>. Finalice con  \"zzz\"");
    input=System.Console.ReadLine();
}
System.Console.WriteLine("Nro)   Nombre         Edad   DNI.");

for (int i = 0; i < lista.Count; i++)
{
    System.Console.WriteLine($"{i+1})    {lista[i].nombre,-17}{lista[i].edad,-7}{lista[i].dni}");
}



Persona ingreso(string? str)
{
    int i=0;
    string aux="";
    Persona P= new Persona();
    while (str[i]!=',')
    {
        aux+=str[i];
        i++;
    }
    P.nombre=aux;
    aux="";
    i++;
    while (str[i]!=','){
        aux+=str[i];
        i++;
    }
    P.dni=aux;
    aux="";
    i++;
    for (; i < str.Length; i++)
    {
        aux+=str[i];
    }
    P.edad= int.Parse(aux);
    return P;
}

