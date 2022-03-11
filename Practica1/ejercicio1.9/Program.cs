/*
9. Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>,
y determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
devuelve el último carácter de st.

juan nauj
*/
bool sonSimetricas;
string ?palabras;//,palabra1,palabra2;
Console.WriteLine("Escriba las 2 palabras separadas por espacio");

palabras = Console.ReadLine();


if (palabras[palabras.Length/2]==' '){
    int i = 0;
    int j = palabras.Length-1;
    sonSimetricas=true;
    while ((sonSimetricas)&&(i<j))
    {
        if (palabras[i]!= palabras[j])
        {
            sonSimetricas=false;
        }
        else
        {
            i++;
            j--;
        }
    }
}
else
{
    sonSimetricas=false;
}




/*

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
*/
if (sonSimetricas) Console.WriteLine("Son simetricas");
else Console.WriteLine("No son simétricas!!");



Console.ReadLine();
