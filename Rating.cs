using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rating");
            Console.Write("Введіть число від 1 до 100 -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 100 || num < 1)
                Console.WriteLine("Ви ввели неправильне число");
            else if (num >= 90)
                Console.WriteLine("Відмінно");
            else if (num >= 75)
                Console.WriteLine("Добре");
            else if (num >= 65)
                Console.WriteLine("Задовільно");
            else if (num >= 60)
                Console.WriteLine("Зараховано");
            else if (num < 60)
                Console.WriteLine("Не зараховано");
        }
    }
}
