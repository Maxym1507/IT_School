using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число -> ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = {0} | ", N);
            for(int i = 0; i*i <= N; i++)
                Console.Write("{0} ", i*i);
            Console.WriteLine();
        }
    }
}
