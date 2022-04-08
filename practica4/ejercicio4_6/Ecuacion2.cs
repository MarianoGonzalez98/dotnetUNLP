class Ecuacion2
{
    double a;
    double b;
    double c;

    public Ecuacion2(double a,double b, double c)
    {
        this.a=a;
        this.b=b;
        this.c=c;
    }
    //GetDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene la siguiente formula, (b^2)-4*a*c.

    public double GetDiscriminante()
    {
        return (b*b)-4*a*c;
    }
    
    //GetCantidadDeRaices(): devuelve 0, 1 ó 2 dependiendo de la cantidad de raíces reales que posee la ecuación. Si el discriminante es negativo no tiene raíces reales, si el discriminante es cero tiene una única raíz, si el discriminante es mayor que cero posee 2 raíces reales.

    public int GetCantidadDeRaices()
    {
        if (this.GetDiscriminante()<0)
        {
            return 0;
        }
        else if  (this.GetDiscriminante()==0)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
    //ImprimirRaices(): imprime la única o las 2 posibles raíces reales de la ecuación. En caso de no poseer soluciones reales debe imprimir una leyenda que así lo especifique.
    public async void ImprimirRaices()
    {
        if (this.GetCantidadDeRaices()==0)
        {
            System.Console.WriteLine("No tiene solucion real");
        }
        else if (this.GetCantidadDeRaices()==1)
        {
            double raiz=-(b/(2*a));
            System.Console.WriteLine($"La raiz es {raiz:0.00}");
        }
        else
        {
            double raiz1;
            double raiz2;

            raiz1= Math.Sqrt(b*b-4*a*c);
            raiz2=raiz1;

            raiz1= - b +raiz1;
            raiz1= raiz1/(2*a);

            raiz2= - b -raiz2;
            raiz2= raiz2/(2*a);
            System.Console.WriteLine($"Las raices son {raiz1:0.00} y {raiz2:0.00}");
        }
    }
}