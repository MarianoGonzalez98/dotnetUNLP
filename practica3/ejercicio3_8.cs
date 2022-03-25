var a = 3L;
dynamic b = 32;
object obj = 3;
a = a * 2.0; //error: no se puede convertir implicitamente double en long
b = b * 2.0;
b = "hola";
obj = b;
b = b + 11;
obj = obj + 11; // el operador + no se puede aplicar a un operador tipo objeto
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
f.Edad = 22; //no se puede asignar un nuevo dato porque los tipos anonimos son de solo lectura
d = c;
e = d; // son de diferente tipos anonimos
f = e;// son de diferente tipos anonimos
