using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Course {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do Títular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá um deposito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com a quantia para depósito: ");
            double quantia = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizada: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com a quantia para o saque: ");
            double saque = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizada: ");
            Console.WriteLine(conta);
        }
    }
}