using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG     ";

            //Converte tudo para maiúsculo
            string s1 = original.ToUpper();

            //Converter tudo para minúsculo
            string s2 = original.ToLower();

            //Apagar os espaços em branco
            string s3 = original.Trim();

            //Primeira contagem de Ocorrência
            int n1 = original.IndexOf("bc");

            //Última contagem de Ocorrência
            int n2 = original.LastIndexOf("bc");

            //Recortar string
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            //Substituir um caracter
            string s6 = original.Replace("a", "x");

            //Substituir string
            string s7 = original.Replace("abc", "xy");

            //Verificar se há espaços em branco
            bool b1 = String.IsNullOrEmpty(original);

            //Verifcar espaços em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("-ToUpper: " + s1+ "-");
            Console.WriteLine("-ToLower: " + s2 + "-");
            Console.WriteLine("-Trim: " + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf('bc'): -" + n2 + "-");
            Console.WriteLine("Subtring('3'): -" + s4 + "-");
            Console.WriteLine("Subtring('3, 5'): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullorEmpty: " + b1);
            Console.WriteLine("IsNullorWhiteSpace: " + b2);

        }
    }
}