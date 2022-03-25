/* 4. Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que
devuelven un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la matriz no es cuadrada generar una excepción ArgumentException. */

double[,] mtr = new double[3,4]
    { {1,2,3,4},
    {4,5,6,7},
    {7,8,9,10}};

double[] matriz= GetDiagonalSecundaria(mtr);
for (int i = 0; i < matriz.Length; i++)
{
    Console.Write(matriz[i]+" ");
}


double[] GetDiagonalPrincipal(double[,] matriz)
{
    if (matriz.GetLength(0)==matriz.GetLength(1))
    {
        throw new ArgumentException("matriz");
    }
    int cant= matriz.GetLength(0);
    double[] resultado = new double[cant];
    for (int i = 0; i < cant; i++)
    {
        resultado[i]=matriz[i,i];
    }
    return resultado;
}
double[] GetDiagonalSecundaria(double[,] matriz)
{
    if (matriz.GetLength(0)!=matriz.GetLength(1))
    {
        throw new ArgumentException("La matriz no es cuadrada");
    }
    int cant= matriz.GetLength(0);
    int col=cant-1;
    double[] resultado = new double[cant];
    
    for (int i = 0; i < cant ; i++)
    {
        resultado[i]=matriz[i,col];
        col--;
    }
    return resultado;
}
