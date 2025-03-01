using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //ref:

            /*

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            */

            //out:

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}