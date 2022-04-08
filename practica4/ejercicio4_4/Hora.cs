namespace ejercicio4_4
{
    public class Hora
    {
        int _segundosEnt;
        decimal _segundosDec;
        bool _enDecimal;
        int _minutos;
        int _horas;
        
        public Hora(int horas,int minutos, int segundos)
        {
            this._horas=horas;
            this._minutos=minutos;
            this._segundosEnt=segundos;
            this._enDecimal=false;
        }
        public Hora(double hora)
        {   
            decimal dec=(decimal)hora;
            this._horas=(int)hora;
            decimal aux=(dec - (decimal)_horas)*(decimal)60;
            this._minutos= (int)aux;
            this._segundosDec=(aux -(decimal)_minutos)*(decimal)60;
            this._enDecimal=true;
        }

        public void Imprimir()
        {
            if (_enDecimal)
            {
            System.Console.WriteLine($"{_horas} horas, {_minutos} minutos y {_segundosDec:0.000} segundos");
            }
            else
            {
                System.Console.WriteLine($"{_horas} horas, {_minutos} minutos y {_segundosEnt} segundos");
            }

        }
    }
}