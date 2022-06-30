using System;
using Clib;
namespace ConsoleAppClib
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClib tl= new TestClib();
            Console.WriteLine("Введите строку:");
            string d = Console.ReadLine();
            Console.WriteLine($"Удвоенная строка:{  tl.Double(d)}");
            Console.WriteLine($"Количество гласных:{tl.Glas(d)}");
            Console.WriteLine($"Количество согласных:  {tl.soGlas(d)}");
            if (tl.WhatMore(d))
            {
                Console.WriteLine($"гласных больше");
            }
            else
            {
                Console.WriteLine($"согласных больше:");
            }

        }
    }
}
