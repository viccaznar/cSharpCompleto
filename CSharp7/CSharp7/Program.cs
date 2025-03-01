using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual a hora atua? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora <= 18) {
                Console.WriteLine("Boa Tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}

