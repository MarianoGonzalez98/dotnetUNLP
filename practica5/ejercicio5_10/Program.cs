/* 10) Identificar todos los miembros en la siguiente declaración de clase.

Indicar si se trata de un constructor, método, campo, propiedad o indizador, si es estático o de instancia, y en caso que corresponda si es de sólo lectura, sólo escritura o lectura y escritura.

En el caso de las propiedades indicar también si se trata de una propiedad auto-implementada.

Nota: La clase compila perfectamente. Sólo prestar atención a la sintaxis, la semántica es irrelevante. 
*/

class A
{
    private static int a; //campo
    private static readonly int b; //campo
    A() { } //constructor
    public A(int i) : this() { } //constructor
    static A() => b = 2; //constructor?? (revisar)
    int c; //campo
    public static void A1() => a = 1; // metodo estatico
    public int A1(int a) => A.a + a; //metodo de instancia
    public static int A2; //campo estatico
    static int A3 => 3; //propiedad estatica de solo lectura ??
    private int A4() => 4; //metodo de instancia
    public int A5 { get => 5; }
    int A6 { set => c = value; }
    public int A7 { get; set; }
    public int A8 { get; } = 8;
    public int this[int i] => i;
}