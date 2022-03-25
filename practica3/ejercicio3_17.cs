/* 
17. Implementar un programa calculadora que calcule una expresión ingresada por el usuario
correspondiente a una operación binaria de las cuatro elementales (ejemplo “44.5/456”,
“456*45”, “549-12”, “54+6” ). Utilizar try/catch para validar los números y controlar
cualquier tipo de excepción que pudiese ocurrir en la evaluación de la expresión.
 */

Console.Write("Ingrese una expresion aritmetica del tipo <operando1><operador><operando2> : ");
string? str= Console.ReadLine();
string numStr="";
char operador='x';
double num1=0;
double num2=0;
int i=0;

try
{
    for ( i = 0; i < str.Length; i++)
    {
        if (! (str[i]=='+' || str[i]=='-' || str[i]=='*' || str[i]=='/'  ))
        {
            numStr+=str[i];
        }
        else
        {
            operador=str[i];
            num1=double.Parse(numStr); //guarda el primer operando
            numStr="";
        }
    }
    num2=double.Parse(numStr); //guarda el segundo operando
    double resultado=0;
    switch (operador)
    {
        case '+': 
            resultado= num1+num2;
            break;
        case '-':
            resultado= num1-num2;
            break;
        case '*': 
            resultado= num1*num2;
            break;
        case '/':
            resultado= num1/num2;
            break;
    }
    Console.Write("Resultado: "+resultado);
}
catch (FormatException)
{
    Console.WriteLine("Formato aritmetico incorrecto");
}


