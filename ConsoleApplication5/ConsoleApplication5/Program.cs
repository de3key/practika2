using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число ");
            double y = Convert.ToDouble(Console.ReadLine());
            double zy = -5 * Math.Sqrt(z + Math.Sqrt(y));
            Console.WriteLine(" ответ :" + zy);
            Console.ReadKey();
        }
    }
}
