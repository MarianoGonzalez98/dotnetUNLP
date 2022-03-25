/* 7. ¿De qué tipo quedan definidas las variables x, y, z en el siguiente código? */
int i = 10; //int32
Console.WriteLine("int i = 10 " +i.GetType()!);
var x = i * 1.0; //double
Console.WriteLine("var x = i * 1.0 " +x.GetType()!);
var y = 1f; //float
Console.WriteLine("var y = 1f "+ y.GetType()!);
var z = i * y; //float
Console.WriteLine("var z = i * y " +z.GetType()!);
