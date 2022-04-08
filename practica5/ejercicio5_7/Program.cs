/* 7) Definir la clase Persona con las siguientes propiedades de lectura y escritura: Nombre de tipo
string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento de tipo DateTime. Además
definir una propiedad de sólo lectura (calculada) Edad de tipo int. Definir un indizador de
lectura/escritura que permita acceder a las propiedades a través de un índice entero. Así, si p es un
objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es descartado. Observar
que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string. */

Persona P1 = new Persona();
P1[3]= Convert.ToDateTime("25/04/1998");
System.Console.WriteLine(P1[4]);
P1.Dni=41099564;
//P1.Nombre="Mariano";
Persona P2 = new Persona();
P2.Dni=20480381;
P2.Nombre="Patricia";
ListaDePersonas lista= new ListaDePersonas();
lista.Agregar(P1);
lista.Agregar(P2);
if (lista[2048038]==null)
{
    System.Console.WriteLine("Es null");
}

System.Console.WriteLine("La cantidad es: "+ lista['P'].Count);