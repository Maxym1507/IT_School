using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_from_1_to_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть будь-яке ціле додатнє число -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1)
            {
                int sum = 0;
                for (int i = 1; i <= num; i++)
                    sum += i;
                Console.WriteLine("Сума чисел від 1 до {0} = {1}", num, sum);
            }
            else Console.WriteLine("Ви ввели неправильне число!");
        }
    }
}
