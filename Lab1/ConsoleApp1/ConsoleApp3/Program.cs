using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Написать программу, которая подсчитывает периметр прямоугольного треугольника по двум катетам a,b */

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размеры катетов прямоугольного треугольника. Катет а = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Катет b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * a + b * b;
            int perim = a + b + c;
            Console.WriteLine($"Периметр прямоугольного треугольника = {perim}");
            Console.ReadKey();            
        }
    }
}
