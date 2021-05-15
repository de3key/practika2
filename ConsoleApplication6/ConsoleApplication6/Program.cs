using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            double a2 = a / (b * c);
            Console.WriteLine("ответ:" + a2);
            Console.ReadKey();
        }
    }
}
