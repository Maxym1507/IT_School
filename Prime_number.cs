using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(Convert.ToDouble(n))); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Це число не є простим");
                    break;
                }
                if (i == Convert.ToInt32(Math.Sqrt(Convert.ToDouble(n))) )
                    Console.WriteLine("Це число є простим");
            }
            if(n == 2)
                Console.WriteLine("Це число є простим");
        }
    }
}
