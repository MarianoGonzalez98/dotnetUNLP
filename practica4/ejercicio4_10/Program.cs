// 10) ¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?

class A
{
    public void Metodo(short n)
    {
        Console.Write("short {0} - ", n);
    }
    public void Metodo(int n)
    {
    Console.Write("int {0} - ", n);
        }

//es incorrecta porque este metodo tiene la misma cantidad y tipo de parametros que el anterior(un tipo de parametro integer)
    public int Metodo(int n) 
    {
        return n + 10;
    }
}