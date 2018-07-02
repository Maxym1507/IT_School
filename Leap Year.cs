using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year");
            Console.Write("Введіть рік -> ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("{0} рік високосний", year);
            else Console.WriteLine("{0} рік не є високосним", year);
        }
    }
}
