using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число a3");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double a4 = a1 * a2 + a1 * a3 + a2 * a3;
            Console.WriteLine("ответ:" + a4);
            Console.ReadKey();
        }
    }
}
