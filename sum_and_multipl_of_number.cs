using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_multipl_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, mult = 1;
            while (num != 0)
            {
                sum += num % 10;
                mult *= num % 10;
                num /= 10;
            }
            Console.WriteLine("Сума  цифр: {0}", sum);
            Console.WriteLine("Добуток цифр: {0}", mult);
        }
    }
}
