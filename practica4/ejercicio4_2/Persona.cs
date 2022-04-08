class Persona
{
    string _nombre;
    int _edad;
    string _dni;


    

    public Persona(string nombre,int edad, string dni)
    {
        this._nombre=nombre;
        this._edad=edad;
        this._dni=dni;
    }
    public void Imprimir()
    {
        System.Console.WriteLine($"{_nombre,-20}{_edad,-7}{_dni}");
    }

     public string getNombre()
    {
        return _nombre;
    } 

    public bool EsMayorQue(Persona p)
    {
        return this._edad>p._edad;
    }
}
