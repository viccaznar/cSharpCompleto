using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {


            //Conversões de DateTime (ToLocal() e ToUniversalTime())
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 toLocal: " + d1.ToLocalTime());
            Console.WriteLine("d1 toLocal: " + d1.ToUniversalTime());
            Console.WriteLine();

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 toLocal: " + d2.ToLocalTime());
            Console.WriteLine("d2 toLocal: " + d2.ToUniversalTime());
            Console.WriteLine();

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 toLocal: " + d3.ToLocalTime());
            Console.WriteLine("d3 toLocal: " + d3.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            //Padrão ISO 8601

            //Fomato yyyy-MM-dd HH:mm:ssZ       Z: indica que o DateTime está em UTC

            DateTime z1 = DateTime.Parse("2000-08-15 10:10:10");
            Console.WriteLine(z1);

            DateTime z2 = DateTime.Parse("2000-08-15T10:10:10Z");
            Console.WriteLine(z2);

        }
    }
}