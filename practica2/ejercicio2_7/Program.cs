//7. Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué?

char c;
char? c2;
string? st;
//c = ""; // no se puede convertir implicitamente el String en char
c = ' '; //no existe el caracter vacio
//c = null; // char no acepta el valor null
//c2 = null;
c=(char)65;
c2= (char?)65; //¿porque esto da A y lo de abajo null???
c2 = (65 as char?); 
st = "";
//st = ''; //no se puede convertir el char en string
st = null;
//st = (char)65; // no se puede convertir implicitamente el tipo char en string (si explicitamente int a char)
//st = (string)65; //No se puede convertir el tipo 'int' en 'string' (implicitamente ni explicitamente, hay que usar el toString)
st = 47.89.ToString();




Console.WriteLine("Hello, World!");
