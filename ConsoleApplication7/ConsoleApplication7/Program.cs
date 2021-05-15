using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            double x2 = -1 / Math.Pow(x, 2);
            Console.WriteLine("ответ:" + x2);
            Console.ReadKey();
        }
    }
}
