using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace QuestionThirteen
{
    class Program
    {
        static void Main(string[] args)
        {
           double decimalNumber = 0;
            int i = 0;
            int remainder,n;
            Console.WriteLine("Enter  a binary number");
            n = int.Parse(Console.ReadLine());
            while (n!=0)
            {
                remainder = n % 10;
                n /= 10;
                decimalNumber += remainder*(Math.Pow(2,i));
                ++i;

            }
            Console.WriteLine("Decimal number" + decimalNumber);


            Console.ReadKey();
            

        }
    }
}
