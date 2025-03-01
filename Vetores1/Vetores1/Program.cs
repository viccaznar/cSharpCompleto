using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de espaços do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite a altura #" + (i + 1) + ": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine();
            Console.WriteLine("Média das alturas = " + avg.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
