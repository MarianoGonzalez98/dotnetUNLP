/* 7) Definir la clase Persona con las siguientes propiedades de lectura y escritura: 
Nombre de tipo string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento de tipo DateTime. 
Además definir una propiedad de sólo lectura (calculada) Edad de tipo int. 

Definir un indizador de lectura/escritura que permita acceder a las propiedades a través de un índice entero. 

Así, si p es un objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de nacimiento y p[4] a la edad.

En caso de asignar p[4] simplemente el valor es descartado. 

Observar que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string. */
class Persona
{
    public string? Nombre{get;set;}
    public char? Sexo{get;set;}
    public int? Dni{get;set;}
    public DateTime? FechaNacimiento{get;set;}
    public int Edad
    {
        get
        {

            if (FechaNacimiento.HasValue)
            {
                int edad= (DateTime.Today.AddTicks(-FechaNacimiento.Value.Ticks).Year - 1);
                return edad;
            }
            else
            return -1;
        }
    }

public object? this[int i]
{
    get
    {
        switch (i)
        {
            case 0: return this.Nombre;
            case 1: return this.Sexo;
            case 2: return this.Dni;
            case 3: return this.FechaNacimiento;
            case 4: return this.Edad;
            default: return null;
        }
    }
    set
    {
        switch (i)
        {
            case 0: this.Nombre=(string?)value;
                break;
            case 1: this.Sexo= (char?)value;
                break;
            case 2: this.Dni= (int?)value;
                break;
            case 3: this.FechaNacimiento = (DateTime?)value;
                break;
            case 4: break;
            default: break;
        }
    }
}

}



/* 
public int GetDifferenceInYears(DateTime startDate, DateTime endDate)
    {
        //Excel documentation says "COMPLETE calendar years in between dates"
        int years = endDate.Year - startDate.Year;

        if (startDate.Month == endDate.Month &&// if the start month and the end month are the same
            endDate.Day < startDate.Day// AND the end day is less than the start day
            || endDate.Month < startDate.Month)// OR if the end month is less than the start month
        {
            years--;
        }

        return years;
    }
 */