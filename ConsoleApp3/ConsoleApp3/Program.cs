using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Propriedades do DateTime
            DateTime d0 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
           
            Console.WriteLine(d0);
            //Data
            Console.WriteLine("1) Date: " + d0.Date);
            //Dia
            Console.WriteLine("2) Day: " + d0.Day);
            //Dia da Semana
            Console.WriteLine("3) DayOfWeek: " + d0.DayOfWeek);
            //Dia do Ano
            Console.WriteLine("4) DayOfYear: " + d0.DayOfYear);
            //Hora
            Console.WriteLine("5) Hour: " + d0.Hour);
            //Kind
            Console.WriteLine("6) Kind: " + d0.Kind);
            //Millisecond
            Console.WriteLine("7) Milliseconds: " + d0.Millisecond);
            //Minute
            Console.WriteLine("8) Minute: " + d0.Minute);
            //Month
            Console.WriteLine("9) Month: " + d0.Month);
            //Second
            Console.WriteLine("10) Second: " + d0.Second); 
            //Ticks
            Console.WriteLine("11) Ticks: " + d0.Ticks);  
            //Hora do Dia
            Console.WriteLine("12) TimeOfDay: " + d0.TimeOfDay);  
            //Ano
            Console.WriteLine("13) Year: " + d0.Year);
            Console.WriteLine();

            //Formatação (DateTime para string [Data Completa])

            //Instância do DateTime
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Imprimindo na forma DateTime
            Console.WriteLine(d1.ToLongDateString());

            //Convertendo e Imprimindo o DateTime em String
            string s1 = d1.ToLongDateString();
            Console.WriteLine(s1);

            //Somente horário do DateTime
            string s2 = d1.ToLongTimeString();
            Console.WriteLine(s2);

            //Somente a data do DateTime
            string s3 = d1.ToShortDateString();
            Console.WriteLine(s3);

            //Somente o horário do DateTime
            string s4 = d1.ToShortTimeString();
            Console.WriteLine(s4);

            //Formato padrão
            string s5 = d1.ToString();
            Console.WriteLine(s5);

            //Somente a data do DateTime
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            //Somente a data do DateTime
            string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s7);

            //Adicionando Horas
            DateTime d2 = new DateTime(2001, 8, 15, 10, 45, 58, 275);
            Console.WriteLine(d2);

            //Adicionando Horas
            DateTime x1 = d2.AddHours(2);
            Console.WriteLine("Horas adicionadas: " + x1);

            //Adicionando Minutos
            DateTime x2 = d2.AddMinutes(3);
            Console.WriteLine("Minutos adicionados: " + x2);

            //Exemplo: Calculando Data de Vencimento (Adicionando 7 dias apartir do dia atual):
            
            DateTime d3 = DateTime.Now;

            DateTime d4 = d3.AddDays(7);
            Console.WriteLine("Data com o acréscimo de 7 dias: " + d4);

            //Saber a diferença entre datas
            DateTime d5 = new DateTime(2002, 01, 31, 10, 0, 00, 300);
            TimeSpan t = d5.Subtract(d2);
            Console.WriteLine(t);


            




        }
    }
}