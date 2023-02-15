using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            int n = 0;
            double sum = 0;
            
            do
            {
                Console.WriteLine("Введите x");
                x = Convert.ToInt32(Console.ReadLine());
            } while (!(Math.Abs(x) > 1));

            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i += 2)
            {
                sum += 1 / (i * Math.Pow(x, i));
            }

            sum *= 2;

            Console.WriteLine(sum);
        }
    }
}
