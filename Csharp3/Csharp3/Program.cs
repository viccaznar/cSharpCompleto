using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Você digitou: " + nome);

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + quartos);

            Console.WriteLine("Entre com o preco de um prouto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com o seu último nome, quantidade de quartos, sexo, preco do produto, altura e idade: ");

            string[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = vet[0];
            int quantidadeQuartos = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double precoProduto = double.Parse(vet[3], CultureInfo.InvariantCulture );
            double altura = double.Parse(vet[4], CultureInfo.InvariantCulture);
            int idade = int.Parse(vet[5]);

            Console.WriteLine("Você digitou: " + ultimoNome);
            Console.WriteLine("Você digitou: " + quantidadeQuartos);
            Console.WriteLine("Você digitou: " + sexo);
            Console.WriteLine("Você digitou: " + precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Você digitou: " + altura);
            Console.WriteLine("Você digitou: " + idade);





        }
    }
}