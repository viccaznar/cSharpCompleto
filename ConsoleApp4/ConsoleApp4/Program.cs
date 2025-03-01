﻿using System;
using System.Globalization;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Windows\Temp\FileInfo.txt";
            StreamReader sr = null;
            try
            {

                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An errour occoured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
        }
    }
}