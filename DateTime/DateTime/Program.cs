using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) { 
        
            //Intancia da Hora atual e função 'Ticks'
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            //Intanciando DateTime no momento escolhido
            DateTime _d1 = new DateTime(2025, 01, 30);
            Console.WriteLine(_d1);

            //Instanciando Horário (Até segundos)
            DateTime d2 = new DateTime(2025, 01, 30, 20, 29, 13);
            Console.WriteLine(d2);

            //Instanciando Horário (Até milisegundo)
            DateTime d3 = new DateTime(2025, 01, 30, 20, 29, 13, 500);
            Console.WriteLine(d3);

            //Hora Local
            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            //Data atual (Hoje)
;            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            //DateTime (Horário atual em GNT)
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            //Converter string para DateTime
            DateTime d7 = DateTime.Parse("30-01-2025");
            Console.WriteLine(d7);

            //Convert string para DateTime com horário
            DateTime d8 = DateTime.Parse("2025-01-30 13:05:58");
            Console.WriteLine(d8); 

            //Convert string para DateTime com horário no formato Brasileiro
            DateTime d9 = DateTime.Parse("30-01-2025 14:54:15");
            Console.WriteLine(d9);

            //Convert string para DateTime costumizado
            DateTime d10 = DateTime.ParseExact("2015-01-30", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            //Convert string para DateTime costumizado com horário no formato Brasileiro
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:08", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);


        }
    }
}