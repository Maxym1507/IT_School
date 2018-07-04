using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num = 0, max = 0;
            do
            {
                Console.Write("Введіть число (якщо хочете завершити - введіть '0') -> ");
                num = Convert.ToInt32(Console.ReadLine());
                if (max == num && num != 0)
                    i++;
                if (max == 0 && num != 0)
                {
                    max = num;
                    i++;
                }
                if (num > max && num != 0)
                {
                    max = num;
                    i = 1;
                }
            } while (num != 0);
            if (i != 0)
                Console.WriteLine("Максимальне число - {0}\nКількість входжень - {1}", max, i);
            else Console.WriteLine("Ви не вводили чисел");
        }
    }
}
