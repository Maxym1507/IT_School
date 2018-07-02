using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.Write("Введіть, яку дію Ви хочете зробити з числами (+,-,*,/) -> ");
            char x = Convert.ToChar(Console.ReadLine());
            Console.Write("Введіть перше число -> ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть друге число -> ");
            double b = Convert.ToDouble(Console.ReadLine());
            double res;
            switch (x)
            {
                case '+':
                    res = a + b;
                    Console.WriteLine("{0} {1} {2} = {3}", a, x, b, res);
                    break;
                case '-':
                    res = a - b;
                    Console.WriteLine("{0} {1} {2} = {3}", a, x, b, res);
                    break;
                case '/':
                    if (b != 0)
                    {
                        res = a / b;
                        Console.WriteLine("{0} {1} {2} = {3}", a, x, b, res);
                    }
                    else Console.WriteLine("Помилка! На 0 ділити не можна!");
                    break;
                case '*':
                    res = a * b;
                    Console.WriteLine("{0} {1} {2} = {3}", a, x, b, res);
                    break;
                default:
                    Console.WriteLine("Такої дії не існує!!!");
                    break;
            }

        }
    }
}