using Course.Services;
using System;

namespace Course
{
    delegate void BinaryNumericOperation(double n1, double n3);

    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.ShowSum;
            op += CalculationServices.ShowMax;

            op.Invoke(a, b);
            



        }
    }
}