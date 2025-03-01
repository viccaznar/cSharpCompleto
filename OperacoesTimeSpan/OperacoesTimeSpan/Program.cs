using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Duração máxima possível de se armazanar no TimeSpan
            TimeSpan t1 = TimeSpan.MaxValue;
            Console.WriteLine(t1);

            //Duração mínima possível de se armazenar no TimeSpan
            TimeSpan t2 = TimeSpan.MinValue;
            Console.WriteLine(t2);

            //Valor zerado do TimeSpan
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t3);

            //Propriedades
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            //Apenas mostrando partes de um TimeSpan (Dia, hora, minuto, segundo, ticks)
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            //Mostrando os Totais por partes de um TimeSpan (Total de dias, horas, minutos, segundos, ticks)
            Console.WriteLine("Total days: " + t.TotalDays);            
            Console.WriteLine("Hours: " + t.TotalHours);
            Console.WriteLine("Minutes: " + t.TotalMinutes);
            Console.WriteLine("Seconds: " + t.TotalSeconds);
            Console.WriteLine("Ticks: " + t.TotalMilliseconds);
            
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            //Operações com TimeSpan
            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            //Adição
            TimeSpan sum = t4.Add(t5);
            Console.WriteLine(sum);

            //Subtração
            TimeSpan def = t4.Subtract(t5);
            Console.WriteLine(def);

            //Multiplicação
            TimeSpan mult = t5.Multiply(2.0);
            Console.WriteLine(mult);

            //Divisão
            TimeSpan div = t5.Divide(2.0);
            Console.WriteLine(div);


        }
    }
}