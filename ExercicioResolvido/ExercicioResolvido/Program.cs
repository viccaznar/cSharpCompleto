using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Course.Entities;
using System.IO; 

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserir o caminho o arquivo
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            //Instanciar a lista tipo Product
            List<Product> list = new List<Product>();

            //Ler o arquivo através da variável path inserida anteriormente 
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    //Instanciar e adicionar o produto na Lista
                    list.Add(new Product(name, price));
                        
                }
            }

            //Encontrar o preço médio de todos os produtoscar
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //Ordenar a lista pelos preços abaixo da média
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
