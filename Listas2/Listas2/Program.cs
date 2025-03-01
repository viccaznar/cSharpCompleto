using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            //Add: Adicionar ao final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
                       

            //Insert: Você pode escolher em qual posição inserir
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------");


            //Count
            Console.WriteLine("List Count: " + list.Count);

            //Find e FindLast
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //Index e IndexLast
            int pos1 = list.FindIndex(x =>  x[0] == 'A');
            Console.WriteLine("First 'A' position: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last 'A' position: " + pos2);

            //FindAll
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------");

            //Remove
            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------");

            list.RemoveRange(2, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            /*

            //RemoveAt
            list.RemoveAt(2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------");

            //RemoveAll
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            */
            


        }

    }
}