using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);

            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(ch);

            //double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}