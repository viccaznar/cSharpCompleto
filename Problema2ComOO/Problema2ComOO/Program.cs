using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            
            /*
           
            Console.WriteLine("Entre com os dados o produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            

            Produto p2 = new Produto();

            Produto p3 = new Produto("TV", 500.00, 10);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p3);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser inserido no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p3.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p3);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser retirado do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p3.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p3);

            Console.WriteLine();
            p3.Nome = "TV LED";
            Console.WriteLine(p3.Nome);
            Console.WriteLine(p3.Preco);

            */

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

   
        }
    }
}