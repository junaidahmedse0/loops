using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two whole numbers n and x");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {

                factorial *= i;
                sum += (factorial / Math.Pow(x, i));

            }
            Console.WriteLine("The sum is "+sum);
            Console.ReadKey();
        }
    }
}
