using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Math.Sqrt(x1 * x2 + x2 * x2);
            Console.WriteLine("ответ: " + x1 + x2);
            Console.ReadKey();
        }
    }
}
