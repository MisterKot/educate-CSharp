using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Написать программу, которая реализует диалог с пользователем:
        запрашивает с клавиатуры три целых числа, и выводит на
        экран произведение данных чисел в прямом и обратном порядке 
    */

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Введите первое число: ");
            String num = Console.ReadLine();
            int a = Int32.Parse(num);
            Console.Write("Введите второе число: ");
            num = Console.ReadLine();
            int b= Int32.Parse(num);
            Console.Write("Введите третье число: ");
            num = Console.ReadLine();
            int c = Int32.Parse(num);
            int y = a * b * c;
            Console.WriteLine($"Произведение чисел: {a}*{b}*{c}={y}");
            Console.WriteLine($"Обратный порядок: {c}*{b}*{a}={y}");
            Console.ReadKey();
        }
    }
}
