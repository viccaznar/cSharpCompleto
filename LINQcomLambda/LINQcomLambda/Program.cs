using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.00, Category = c2 },
                new Product() {Id = 2, Name = "Hammer", Price = 90.00, Category = c1 },
                new Product() {Id = 3, Name = "TV", Price = 1700.00, Category = c3 },
                new Product() {Id = 4, Name = "Notebook", Price = 1300.00, Category = c2 },
                new Product() {Id = 5, Name = "Saw", Price = 80.00, Category = c1 },
                new Product() {Id = 6, Name = "Tablet", Price = 700.00, Category = c2 },
                new Product() {Id = 7, Name = "Camera", Price = 700.00, Category = c3 },
                new Product() {Id = 8, Name = "Printer", Price = 350.00, Category = c3 },
                new Product() {Id = 9, Name = "MacBook", Price = 1800.00, Category = c2 },
                new Product() {Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3 },
                new Product() {Id = 11, Name = "Level", Price = 70.00,   Category = c1 }

            };


            /* Buscar produtos cuja a categoria tinha Tier 1 e Preço < 900.00
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            */
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);



            /* Buscar o categoria Tools e selecionar só o no 
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
             */
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);




            /* Buscar produtos com a letra 'C' e criar um objeto anônimo 
             var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Name });
             */
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAME  STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);




            /* Buscar produtos de Tier 1 e ordenar por nome
             var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
             */
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);


            /* Buscar por Tier 1 através do preço e por nome, ignorndo os 2 primeiros e pegando os 4 próximos.*/

            var r5 =
                (from p in r4
                select p)
                .Skip(2)
                .Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);



            /*
            var r6 = (from p in products select p).FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);

            var r7 =
                (from p in products
                 where p.Price > 3000.00
                 select p).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Defaut test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Defaut test2: " + r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Minimum Price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            //Select & Aggregate

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate Sum: " + r15);
            Console.WriteLine();
            */

            /* var r16 = products.GroupBy(p => p.Category); */
            var r16 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }

    }
}







