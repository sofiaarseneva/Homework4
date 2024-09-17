using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести целое число N > 0.Найти квадрат данного числа, используя для его вычисления следующую формулу: N2 = 1 + 3 + 5 + ... +(2 * N – 1). 
            //После добавления к сумме каждого слагаемого выводить текущее значение суммы(в результате будут выведены квадраты всех целых чисел от 1 до N).

            Console.WriteLine("Введите число N, большее нуля:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sumN = 0;

            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    sumN = sumN + (2 * i - 1);
                    Console.WriteLine("Текущее значение суммы (квадрат числа {0}): {1}", i, sumN);
                }
                Console.WriteLine("Итоговый ответ: {0}", sumN);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Некорректно введено число N!");
                Console.ReadKey();
            }
            
        }
    }
}
