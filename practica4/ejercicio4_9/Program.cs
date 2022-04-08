/* 9) Prestar atención a los siguientes programas (ninguno funciona correctamente) */

/* Foo f = new Foo();
f.Imprimir();
class Foo
{
    string? _bar;
    public void Imprimir()
    {
        Console.WriteLine(_bar.Length);
    }
} */
//se inicializa _bar en null automaticamente. Las variables de instancia se inicializan automaticamente

/* Foo f = new Foo();
f.Imprimir();
class Foo
{
    public void Imprimir()
    {
        string? _bar;
        Console.WriteLine(_bar.Length);
    }
} */
//las variables locales no se inicializan automaticamente.

/* ¿Qué se puede decir acerca de la inicialización de los objetos? ¿En qué casos son inicializados automáticamente y con qué valor? 



*/
