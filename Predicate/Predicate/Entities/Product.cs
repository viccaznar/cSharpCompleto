using System;
using System.Globalization;

namespace Course.Entities
{
    class Product
    {
        public string Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public override string ToString()
        {
            return Nome + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
