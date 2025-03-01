using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Instanciando TimeSpan (HH:mm:ss)
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            //Instanciando TimeSpan (Construtor Vazio)
            TimeSpan t2= new TimeSpan();
            Console.WriteLine(t2);

            //Instanciando TimeSpan (Quantidade de Ticks)
            TimeSpan t3 = new TimeSpan(900000000);
            Console.WriteLine(t3);

            //Instanciando TimeSpace (Quantidade de Dias)
            TimeSpan t4 = new TimeSpan(1 ,2 , 11, 21);
            Console.WriteLine(t4);

            //Instanciando TimeSpace (Quantidade de Dias)
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);

            //Instanciando TimeSpace (TimeSpan.FromDays)
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            //Instanciando TimeSpace (TimeSpan.FromHours)
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            //Instanciando TimeSpace (TimeSpan.FromSeconds)
            TimeSpan t8 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t8);

            //Instanciando TimeSpace (TimeSpan.FromMillseconds)
            TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t9);

            //Instanciando TimeSpace (TimeSpan.FromTicks)
            TimeSpan t10 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(10);
        }
    }
}