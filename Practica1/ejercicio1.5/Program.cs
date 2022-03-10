/*
5. Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María”
debe imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso,
debe imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha
ingresado una línea vacía.

a) utilizando if ... else if
b) utilizando switch

*/
Console.WriteLine("Ingrese su nombre");
string nombre= Console.ReadLine();
string mensaje;

//a
if (nombre == "Juan") 
{
    mensaje = "Hola amigo!";
}
else if (nombre == "Maria")
{
    mensaje = "Buen dia señora";
}
else if (nombre == "Alberto”")
{
    mensaje = "Hola Alberto";
}
else if (nombre != "")
{
    mensaje = "Buen diaaaa "+ nombre;
}
else
{
    mensaje = "Buen dia mundo";
}
Console.WriteLine(mensaje);



//b
switch (nombre)
{
    case "Juan":
        mensaje = "Hola amigo!";
        break;
    case "Maria":
        mensaje= "Buen dia señora";
        break;
    case "Alberto":
        mensaje ="Hola Alberto";
        break;
    case "":
        mensaje = "Buen dia mundo";
        break;
    default:
        mensaje = "Buen dia "+ nombre;
        break;

}

Console.WriteLine(mensaje);


Console.ReadLine();
