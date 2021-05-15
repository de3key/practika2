using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            double d = a - b;
            double e = a * b;
            double f = a / b;
            Console.WriteLine("ответ:" + c);
            Console.WriteLine("ответ:" + d);
            Console.WriteLine("ответ:" + e);
            Console.WriteLine("ответ:" + f);
            Console.ReadKey();
        }
    }
}
