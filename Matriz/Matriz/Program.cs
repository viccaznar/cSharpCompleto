using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Instanciando uma Matriz
            double[,] mat = new double[2, 3];

            //Length: Mostra quantos elementos a matriz possui
            Console.WriteLine(mat.Length);

            //Quantidade de elementos dentro da matriz
            Console.WriteLine(mat.Rank);

            //Tamanho da primeira dimensão: Que são as Linhas
            Console.WriteLine(mat.GetLength(0));

            //Tamanho da segunda dimensão: Que são as Colunas
            Console.WriteLine(mat.GetLength(1));
        }
    }
    
}