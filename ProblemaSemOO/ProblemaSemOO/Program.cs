using System;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace ProblemaSemOO {
    class Program {
        static void Main(string[] args) {

            //Fazer um programa para ler as medidas dos lados de dois triângulos X e Y(suponha medidas
            //válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
            //possui a maior área.   

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triangulo X: ");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Àrea  de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Àrea  de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else { 
                Console.WriteLine("Maior área: Y");
            }



        }

    }    
}