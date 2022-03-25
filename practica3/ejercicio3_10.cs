/* 10. Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos compuestos redondea o trunca cuando se formatean números reales restringiendo la cantidad de decimales.
Plantear los ejemplos con cadenas de formato compuesto y con cadenas interpoladas. */

double a=1.51;
double b=1.551;
double c=1.4449;
double d= 1.49;
Console.WriteLine("Formato compuesto {0} {1} {2} {3}",a,b,c,d);
Console.WriteLine("Formato compuesto {0:0.0} {1:0.0} {2:0.0} {3:0.0}",a,b,c,d);
Console.WriteLine("Formato compuesto {0:0.00} {1:0.00} {2:0.00} {3:0.00}",a,b,c,d);
Console.WriteLine("Formato compuesto {0:0.000} {1:0.000} {2:0.000} {3:0.000}",a,b,c,d);

//redondea
