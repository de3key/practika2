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
            Console.WriteLine("введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = -7.5 * Math.Pow(a, 2);
            Console.WriteLine("Ответ: " + a2);
            Console.ReadKey();
        }
    }
}
