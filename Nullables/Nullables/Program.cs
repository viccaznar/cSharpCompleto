using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x);

            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(y);

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("X is null");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            } else {
                Console.WriteLine("Y is null");
            }

            Console.WriteLine("----------------------------------------------");

            double? z = null;
            double? w = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }

    }
}