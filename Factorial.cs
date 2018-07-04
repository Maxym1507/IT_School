using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число, факторіал якого Ви хочете дізнатися -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            if (num >= 1)
            {
                for (int i = 1; i <= num; i++)
                    res *= i;
                Console.WriteLine("Факторіал числа {0} = {1}", num, res);
            }
            else Console.WriteLine("Ви ввели неправильне число");
        }
    }
}
