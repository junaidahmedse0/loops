using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number:: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("result is this:: "+(Fact(2*n)/(Fact(n+1)*Fact(n))));



            Console.ReadKey();

        }
        static BigInteger Fact(int n)
        {

            if (n < 1) return 1;
            return n * Fact(n - 1);
        }
    }
}
