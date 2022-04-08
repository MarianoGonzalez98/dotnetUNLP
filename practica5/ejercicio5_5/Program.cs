
class A
{
    char c;
    static string st;
    void metodo1()
    {
        st = "string";
        c = 'A';
    }
    static void metodo2()
    {
        new A().c = 'a'; //??
        st = "st2";
        c = 'B';        //no se puede usar variables de instancia (no hay un objeto instanciado) en un metodo estatico
        new A().st = "otro string"; //st es una variable estatica, no se la puede llamar desde una instancia?
    }
}