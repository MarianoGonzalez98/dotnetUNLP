using System.Text;

/* 12. Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un carácter una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. Por ejemplo: para la siguiente tabla de caracteres: 

A B C D E F G H I J  K  L  M  N  Ñ  O  P  Q  R  S  T  U  V  W  X  Y  Z sp
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28

Si la clave es {5,3,9,7} y el mensaje a cifrar “HOLA MUNDO”
Se cifra de la siguiente manera:

H  O  L  A  sp M  U  N  D  O  ← Mensaje original
8  16 12 1  28 13 22 14 4  16 ← Código sin cifrar
5  3  9  7  5  3  9  7  5  3  ← Clave repetida
13 19 21 8  5  16 3  21 9  19 ← Código cifrado
M  R  T  H  E  O  C  T  I  R  ← Mensaje cifrado

A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que la suma fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola con los números de la clave encolados y a medida que se desencolen para utilizarlos en el cifrado, se vuelvan a encolar para su posterior utilización. Programar un método para cifrar y otro para descifrar.

*/
string str= "HOLA MUNDO";

Queue<int> clave= new Queue<int>();
clave.Enqueue(5);
clave.Enqueue(3);
clave.Enqueue(9);
clave.Enqueue(7);

Console.WriteLine(Cifrar(str,clave));


string Cifrar(string mensajeOriginal,Queue<int> clave)
{
    StringBuilder car= new StringBuilder("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ");
    StringBuilder mensaje= new StringBuilder(mensajeOriginal);
    for (int i = 0; i < mensaje.Length; i++) //recorro el mensaje
    {
        char letra = mensaje[i]; //guardo letra act
        int numLetra=0;
        //------devuelve numero de letra act
        for (int j = 0; j < car.Length; j++) //busca valor numerico de la letra
        {
            if (letra==car[j]) 
            {
                numLetra= j+1;
                break;
            }
        }
        //---aplico cifrado a letra
        numLetra += clave.Peek(); // sumo num de clave a la letra
        clave.Enqueue(clave.Dequeue()); //rota la cola
        if (numLetra>28) //correccion por si se pasa del numero 28
        {
            numLetra-=28;
        }
        letra=car[numLetra-1]; //letra cifrada
        mensaje[i]=letra; //guarda la letra en el mensaje
    }   
    return mensaje.ToString();
}
