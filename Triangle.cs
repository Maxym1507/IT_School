using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Трикутник");
            Console.Write("Введіть першу сторону -> ");
            double a = Convert.ToDouble(Console.ReadLine());
            double max = a;
            Console.Write("Введіть другу сторону -> ");
            double b = Convert.ToDouble(Console.ReadLine());
            max = (max < b ? b : max);
            Console.Write("Введіть третю сторону -> ");
            double c = Convert.ToDouble(Console.ReadLine());
            max = (max < c ? c : max);
            if (max == a)
            {
                if (max < b + c)
                    Console.WriteLine("Трикутник можна скласти");
                else Console.WriteLine("Трикутник не можна скласти");
            }
            if (max == b)
            {
                if (max < a + c)
                    Console.WriteLine("Трикутник можна скласти");
                else Console.WriteLine("Трикутник не можна скласти");
            }
            if (max == c)
            {
                if (max < a + b)
                    Console.WriteLine("Трикутник можна скласти");
                else Console.WriteLine("Трикутник не можна скласти");
            }
        }
    }
}
