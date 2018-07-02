using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum number");
            double max;
            Console.Write("Введіть перше число -> ");
            double a = Convert.ToDouble(Console.ReadLine());
            max = a;
            Console.Write("Введіть друге число -> ");
            double b = Convert.ToDouble(Console.ReadLine());
            max = (max < b ? b : max);
            Console.Write("Введіть третє число -> ");
            double c = Convert.ToDouble(Console.ReadLine());
            max = (max < c ? c : max);
            Console.WriteLine("Найбільше число - {0}", max);
        }
    }
}
