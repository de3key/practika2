using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            double ab = (a + b) / 2;
            Console.WriteLine("ответ:" + ab);
            Console.ReadKey();

        }
    }
}
