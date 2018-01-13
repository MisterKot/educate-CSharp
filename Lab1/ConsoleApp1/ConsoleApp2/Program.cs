using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое трехзначное число: ");
            String num = Console.ReadLine();
            
            int [] nums = new int[num.Length];
            for (int i = 0; i<num.Length; i++)
            {
                nums[i] = Convert.ToInt32(num[i]);
            }

            int compos = 1; //произведение

            foreach (int a in nums)
            {
                compos *= a;
            }
            Console.WriteLine($"Произведение цифр данного числа = {compos}");
            Console.ReadKey();
     
        }
    }
}
