/* 13) Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing (?? ) y / o la asignación null-coalescing (??=) 

*/

string? st,st1,st2,st3,st4;
st=null;
st1=null;
st2=null;
st3=null;
st4=null;


st= st1 ?? (st2 ?? st3);

if (st1 == null)
{
    if (st2 == null)
    {
        st = st3;
    }
    else
    {
        st = st2;
    }
}
else
{
    st = st1;
}

st4 ??= "valor por defecto"; //si st4 es nulo, le asigno un valor por defecto

if (st4 == null)
{
    st4 = "valor por defecto";
}
