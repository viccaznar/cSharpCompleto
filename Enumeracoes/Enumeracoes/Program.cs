using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program


    {
        //Instanciando um pedido
        static void Main(string[] args) 
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);

            //Convertendo Enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Convertendo string para Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}