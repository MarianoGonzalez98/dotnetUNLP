/*
9. Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>,
y determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
devuelve el último carácter de st.
*/
Console.WriteLine("Escriba las 2 palabras separadas por ENTER");
string palabra1,palabra2;

palabra1 = Console.ReadLine();
palabra2 = Console.ReadLine();
bool sonSimetricas;
if (palabra1.Length == palabra2.Length)
{
    int i=0;
    sonSimetricas=true;
    while((sonSimetricas)&&(i<palabra1.Length))
    {
        if (palabra1[i]!=palabra2[palabra2.Length-i-1]) sonSimetricas = false;
        else i++;
    }
}
else sonSimetricas=false;

if (sonSimetricas) Console.WriteLine("\'" + palabra1 + "\' y \'"+ palabra2 +"\' son simétricas!!");
else Console.WriteLine("\'" + palabra1 + "\' y \'"+ palabra2 +"\' no son simétricas!!");






Console.ReadLine();