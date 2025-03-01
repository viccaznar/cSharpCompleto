using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //Specifing data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Defining Query Expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Executing the Query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
