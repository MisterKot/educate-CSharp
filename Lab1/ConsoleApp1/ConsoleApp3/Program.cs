using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размеры прямоугольника. Высота: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Ширина: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int perim = a * 2 + b * 2;
            Console.WriteLine($"Периметр прямоугольника = {perim}");
            Console.ReadKey();
            
        }
    }
}
