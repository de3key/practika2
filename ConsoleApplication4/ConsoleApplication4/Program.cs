using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            double x = Convert.ToDouble(Console.ReadLine());
            double b2 = 3 * Math.Sqrt(x);
            Console.WriteLine("Ответ:" + b2);
            Console.ReadKey();

        }
    }
}
