//9) ¿Cuál es el error en el siguiente programa?
//Retorna marca(el campo privado) cuando deberia retornar la propiedad Marca 

Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);

class Auto
{
    private string marca;
    public string Marca
    {
        set
        {
            Marca = value;
        }
        get
        {
            return marca;
        }
    }
}