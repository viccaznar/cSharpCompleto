using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        public static void Main(string[] args) 
        {

            string path = @"C:\Windows\Temp\myfolder";

            try
            {
                //Listar todas as pastas a partir da pasta selecionada (path)
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders) 
                {
                    Console.WriteLine(s);
                }

                //Listar todos os arquivos a partir da pasta selecionada (path)
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");



            }
            catch (IOException e) 
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}