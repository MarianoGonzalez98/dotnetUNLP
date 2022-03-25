/* 5. Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la matriz pasada como parámetro */




double[][] GetArregloDeArreglo(double [,] matriz)
{
    double[][] mtr= new double[matriz.GetLength(0)][];
    for (int i = 0; i < mtr.Length; i++)
    {
        mtr[i]= new double[matriz.GetLength(1)];
    }
    return mtr;
}
