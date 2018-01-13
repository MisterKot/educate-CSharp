using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Определить время падения камня на поверхность земли с высоты h */

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту h = ");
            double h = Convert.ToDouble(Console.ReadLine());
            const double g = 9.81;
            double t = Math.Sqrt(2 * h / g);
            Console.WriteLine($"Время падения тела с высоты {h} метров равно {t:N1} секунд.");
            Console.ReadKey();
        }
    }
}
