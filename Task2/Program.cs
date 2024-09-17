using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
            //Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
            int countPos = 0;
            int countNeg = 0;
            int N = 0;

            Console.WriteLine("Введите последовательность чисел. Окончанием последовательности служит число 0.");
            do
            {
                Console.WriteLine("Введите следующее число последовательности: ");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    countPos++;
                }
                else if (N < 0)
                {
                    countNeg++;
                }
            }
            while (N != 0);

            if (countPos > countNeg)
            {
                Console.WriteLine("Положительных чисел больше, чем отрицательных!");
            }
            else if (countNeg > countPos)
            {
                Console.WriteLine("Отрицательных чисел больше, чем положительных!");
            }
            else if (countPos == countNeg && countNeg != 0 && countPos != 0)
            {
                Console.WriteLine("Количество положительных чисел равно количеству отрицательных!");
            } 
            else
            {
                Console.WriteLine("Ввели только число 0!");
            }

            Console.ReadKey();
             
        }
    }
}
