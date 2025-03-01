using System;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours{ get; set; }

        //Construtor Padrão
        public HourContract () { 
        }

        //Construtor com Argumentos
        public HourContract(DateTime date, Double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Método
        public Double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
