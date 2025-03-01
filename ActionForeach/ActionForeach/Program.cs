using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablete", 350.50));
            list.Add(new Product("HD case", 80.90));

            Action<Product> act = p => { p.Price += p.Price * 0.1; };


            
            list.ForEach(p => p.Price += p.Price * 0.1);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            
        }

        /*
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;       
        }
        */
    }
}