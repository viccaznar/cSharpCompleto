using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Product
    {
        //Propriedades
        public string  Name { get; set; }
        public  double Price { get; set; }

        //Construtor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
