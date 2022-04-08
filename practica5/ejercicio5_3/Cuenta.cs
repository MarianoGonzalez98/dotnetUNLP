class Cuenta
{
    private int _id;
    private int _saldo;
    private static int s_saldoTotal;
    private static int s_cantCuentas;
    private static int s_cantDepositos;
    private static int s_cantExtracciones;
    private static int s_cantExtraccionesFallidas;
    private static int s_montoDepositos;
    private static int s_montoExtracciones;
    private static List<Cuenta> s_listaCuentas;
    public static List<Cuenta> ListaCuentas //propiedad de solo lectura asociada a campo privado
    {
        get
        {
            List<Cuenta> lista = Cuenta.s_listaCuentas.ToList();
            return lista;
        } 
    }

    static Cuenta()
    {
        s_listaCuentas= new List<Cuenta>();
    }

    public Cuenta()
    {
        Cuenta.s_cantCuentas++;
        this._id=Cuenta.s_cantCuentas;
        System.Console.WriteLine($"Se creo la cuenta ID ={this._id}");
        s_listaCuentas.Add(this);
    }

    public Cuenta Depositar(int cant)
    {
        this._saldo += cant;
        Cuenta.s_saldoTotal += cant;
        Cuenta.s_cantDepositos ++;
        Cuenta.s_montoDepositos+= cant;
        System.Console.WriteLine($"Se depositó {cant} en la cuenta {this._id} (Saldo={this._saldo})");
        return this;
    }

    public Cuenta Extraer(int cant)
    {
        if (this._saldo>=cant)
        {
            this._saldo-=cant;
            Cuenta.s_cantExtracciones++;
            Cuenta.s_montoExtracciones+=cant;
            Cuenta.s_saldoTotal-=cant;
            System.Console.WriteLine($"Se extrajo {cant} de la cuenta {this._id} (Saldo={this._saldo})");
        }
        else
        {
            System.Console.WriteLine("Operación denegada - Saldo insuficiente");
            Cuenta.s_cantExtraccionesFallidas++;
        }
        return this;
    }


    public static void ImprimirDetalle()
    {
        System.Console.WriteLine($"Cuentas creadas: {Cuenta.s_cantCuentas}");
        System.Console.WriteLine($"Depositos:       {Cuenta.s_cantDepositos}     -Total depositado: {Cuenta.s_montoDepositos}");
        System.Console.WriteLine($"Extracciones:    {Cuenta.s_cantExtracciones}     -Total extraido:   {Cuenta.s_montoExtracciones}");
        System.Console.WriteLine($"                       -Saldo:            {Cuenta.s_saldoTotal}");
        System.Console.WriteLine($"*Se denegaron {Cuenta.s_cantExtraccionesFallidas} extracciones por falta de fondos");
    }

    public static List<Cuenta> GetCuentas()
    {
        List<Cuenta> lista = Cuenta.s_listaCuentas.ToList();
        return lista;
    }

}