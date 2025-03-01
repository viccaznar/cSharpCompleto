using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o nome do #" + (i + 1) + " Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do #" + (i + 1) + " Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
                Console.WriteLine();

            }

            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma += vect[i].Preco;
            }

            double avg = soma / n;
            Console.WriteLine();
            Console.WriteLine("A média do valor dos produtos é " + avg.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}