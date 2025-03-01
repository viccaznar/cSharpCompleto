using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Número Par");
            } else {
                Console.WriteLine("Número Ìmpar");
            }

            Console.WriteLine("----------------------------------------");





        }
    }
}