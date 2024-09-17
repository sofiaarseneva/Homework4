using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C(без наложений). 
            //Найти количество квадратов, размещенных на прямоугольнике.Операции умножения и деления не использовать.
            Console.WriteLine("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int bTemp = 0;

            while (a - c >= 0)
            {
                a = a - c;
                bTemp = b;

                while (bTemp - c >= 0)
                {
                    bTemp = bTemp - c;
                    i++;
                }
            }

            Console.WriteLine("Количество квадратов равно {0}", i);
            Console.ReadKey();
        }
    }
}
