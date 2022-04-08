/*
2) Modificar el programa anterior haciendo privados todos los campos. Definir un constructor adecuado y un método público Imprimir() que escriba en la consola los campos del objeto con el formato requerido para el listado.


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


    //----para ejercicio 2_3
    Persona minP= new Persona("",999,"");

for (int i = 0; i < lista.Count; i++)
{
    System.Console.Write($"{i+1})    ");
    lista[i].Imprimir();


    if (!lista[i].EsMayorQue(minP))
    {
        minP=lista[i];
    }
}

System.Console.WriteLine("La persona mas joven es "+minP.getNombre());



Persona ingreso(string? str)
{


    int i=0;
    string aux="";
    while (str[i]!=',')
    {
        aux+=str[i];
        i++;
    }
    string nombre=aux;
    aux="";
    i++;
    while (str[i]!=','){
        aux+=str[i];
        i++;
    }
    string dni=aux;
    aux="";
    i++;
    for (; i < str.Length; i++)
    {
        aux+=str[i];
    }
    int edad= int.Parse(aux);
    return new Persona(nombre,edad,dni);
}

