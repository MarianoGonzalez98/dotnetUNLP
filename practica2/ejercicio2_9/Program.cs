using System.Text;

/*
9. Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar
un caso de ejemplo en el que el rendimiento sea claramente superior utilizando
StringBuilder en lugar de string y otro en el que no.

-Para reemplazar determinadas letras de un string

- ¿ver cuando no es util?


*/

//StringBuilder stb = new StringBuilder("Holaa");
//stb[0]='h';
//Console.WriteLine(stb); 
int time= DateTime.Now.Millisecond;
Console.WriteLine(TextoInclusivo("Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata Que bella es la vida vista desde la catedral de la zona  tan hermosa de la plata."));
time= DateTime.Now.Millisecond - time;
Console.WriteLine($"El tiempo del algoritmo fue {time} milisecundos");
Console.WriteLine(DateTime.Now.Millisecond.ToString());


StringBuilder Inclusivo(string str) //transforma palabra en inclusivo
{
    StringBuilder stb = new StringBuilder(str);
    if (stb.Length>1)
    {
        if ((stb[stb.Length-2]!='u') &&((stb[stb.Length-2]=='a')||(stb[stb.Length-2]=='o')))
        {
            stb[stb.Length-2]='e';
        }
        else if ((stb[stb.Length-1]=='a')||(stb[stb.Length-1]=='o'))
        {
            stb[stb.Length-1]='e';
        }
    }
    return stb;
}

StringBuilder TextoInclusivo(string str) //transforma un texto en inclusivo
{
    int start=0; //comienzo de palabra
    StringBuilder aux= new StringBuilder("");
    StringBuilder stb = new StringBuilder(str);

    for (int i = 0; i < stb.Length; i++)
    {
        if ((stb[i]==' ') ||(stb[i]=='.')) //si finaliza palabra
        {
            if (stb.Length>1)
            {
                if ((stb[i-2]=='a')||(stb[i-2]=='o'))
                {
                    stb[i-2]='e';
                }
                else if ((stb[i-1]=='a')||(stb[i-1]=='o'))
                {
                    stb[i-1]='e';
                }
            }
        }
    }
    return stb;
}