/* 6. Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices pasadas como parámetros. 

Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño, en caso de no serlo devolver null.

Para el caso de la multiplicación la cantidad de columnas de A debe ser igual a la cantidad de filas de B, en caso contrario generar una excepción ArgumentException. */
double[,]? Suma(double[,] A, double[,] B)
{
    if((A.GetLength(0)!=B.GetLength(0))
    || (A.GetLength(1)!=B.GetLength(1)))
    {
        return null;
    }

    int cantFil= A.GetLength(0);
    int cantCol= A.GetLength(1);
    
    double[,] matriz = new double[cantFil,cantCol];
    for (int i = 0; i < cantFil; i++)
    {
        for (int j = 0; j < cantCol; j++)
        {
            matriz[i,j]=A[i,j]+B[i,j];
        }
    }
    return matriz;
}
double[,]? Resta(double[,] A, double[,] B)
{
    if((A.GetLength(0)!=B.GetLength(0))
    || (A.GetLength(1)!=B.GetLength(1)))
    {
        return null;
    }

    int cantFil= A.GetLength(0);
    int cantCol= A.GetLength(1);
    
    double[,] matriz = new double[cantFil,cantCol];
    for (int i = 0; i < cantFil; i++)
    {
        for (int j = 0; j < cantCol; j++)
        {
            matriz[i,j]=A[i,j]-B[i,j];
        }
    }
    return matriz;
}
double[,] Multiplicacion(double[,] A, double[,] B)
{
    int filasMatrizA=A.GetLength(0);
    int columnasMatrizB=A.GetLength(1);
    double[,] matriz= new double[filasMatrizA,columnasMatrizB];
    for (int i = 0; i < columnasMatrizB; i++)
    {
        for (int j = 0; j < filasMatrizA; j++)
        {
            //terminar
        }
    }
    return matriz;
}
