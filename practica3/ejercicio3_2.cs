/*
2. Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea en la consola. 

void ImprimirMatriz(double[,] matriz)

Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la
dimensión i. 
*/
/* 

3. Idem al anterior pero ahora con un parámetro más que representa la plantilla de formato que debe aplicarse a los números al imprimirse. La plantilla de formato es un string de acuerdo a las convenciones de formato compuesto, por ejemplo “0.0” implica escribir los valores reales con un dígito para la parte decimal. Observar que no hay inconveniente para implementar dos métodos con el mismo nombre siempre que NO lleven la misma cantidad de parámetros con los mismos tipos y en el mismo orden (sobrecarga de métodos).
void ImprimirMatriz(double[,] matriz, string formatString)

 */
double[,] mtr = new double[,]
    { {1,2,3.0,4},
    {5,6.2,7.4,8},
    {9,10,11,12} };

ImprimirMatriz(mtr);
ImprimirMatriz2(mtr,"0.00");

void ImprimirMatriz(double[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        string str="";
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            str+= matriz[i,j]+" ";
        }
        Console.WriteLine(str);
    }
}

void  ImprimirMatriz2 (double[,] matriz, string formatString) //no me deja poner el mismo nombre
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        string str="";
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            str+= matriz[i,j].ToString(formatString)+" ";
        }
        Console.WriteLine(str);
    }
}
