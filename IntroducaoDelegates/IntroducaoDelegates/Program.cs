using System;
using Course.Services;

namespace Course
{

    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);



            
            /*
            double result1 = CalculationService.Sum(a, b);
            Console.WriteLine(result1);
            double result2 = CalculationService.Max(a, b);
            Console.WriteLine(result2);
            double result3 = CalculationService.Square(a);
            Console.WriteLine(result3);
            */


        }
    }
}