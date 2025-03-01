using System;
using System.Globalization;
using System.Net;

namespace Course {
    class Program {
        static void Main(string[] args) {

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double discount = (price > 20.0) ? price * 0.1 : price * 0.05;

            Console.WriteLine(discount);


        }
    }
}