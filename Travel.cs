using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weather -> ");
            string weather = Console.ReadLine();
            Console.Write("Enter length -> ");
            int length = Convert.ToInt32(Console.ReadLine());
            if (weather == "sunny")
            {
                if (length < 10)
                    Console.WriteLine("Vehicle: none");
                else if (length < 40)
                    Console.WriteLine("Vehicle: bike");
                else if (length < 400)
                    Console.WriteLine("Vehicle: car");
                else if (length < 900)
                    Console.WriteLine("Vehicle: train");
                else if (length >= 900)
                    Console.WriteLine("Vehicle: airplane");
            }
            if (weather == "rainy")
            {
                if (length < 40)
                    Console.WriteLine("Vehicle: car. Ride carefully!");
                else Console.WriteLine("It`s better to wait for better weather.");
            }
        }
    }
}
