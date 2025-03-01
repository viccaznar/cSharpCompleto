using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2) {
                Console.WriteLine("Maior: " + n1);
            } 
            else if (n1 < n2) {
                Console.WriteLine("Maior: " + n2);
            }
            else (Console.WriteLine("Maior: " +  n3));
        }
        }

    }
}