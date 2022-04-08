class Cuenta
{
    private double _monto;
    private int _titularDNI;
    private string? _titularNombre;

/*     public Cuenta()
    {
        this._monto=0;
        this._titularDNI=-1;
        this._titularNombre="No especificado";
    } */
/*     public Cuenta(int dni):this()
    {
        this._titularDNI=dni;
    }
    
    public Cuenta(string nombre):this()
    {
        this._titularNombre=nombre;
    } */
    public Cuenta(string nombre, int dni)
    {
        this._titularDNI=dni;
        this._titularNombre=nombre;
        this._monto=0;
    }
    public Cuenta():this("No especificado",-1)
    {
    }
    
    public Cuenta(int dni):this("No especificado",dni)
    {
    }
    public Cuenta(string nombre):this(nombre,-1)
    {
    }
    public void Imprimir()
    {
        string titularDNI = (_titularDNI==-1) ? "No especificado" : _titularDNI.ToString();
        System.Console.WriteLine($"Nombre: {_titularNombre}, DNI: {titularDNI}, Monto: {_monto}");
    }

    public void Depositar(int deposito)
    {
        this._monto+=deposito;
    }
    
    public void Extraer(int extraccion)
    {
        if (_monto>=extraccion)
        {
            this._monto-=extraccion;
        }
        else
        {
            System.Console.WriteLine("Operacion cancelada, monto insuficiente");
        }
        
    }
}