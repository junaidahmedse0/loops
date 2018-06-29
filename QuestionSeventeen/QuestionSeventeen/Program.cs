using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeventeen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, i, GCD=0,lcm;
            Console.WriteLine("Enter Number1:: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2:: ");
            num2 = int.Parse(Console.ReadLine());
            for (i = 1; i < num1 && i < num2; i++)
            {

                if (num1 % i == 0 && num2 % i == 0)
                {
                    GCD = i;

                }

            }

            Console.WriteLine("Greatest Common divisor is:: " + GCD);

            lcm = (num1 * num2) / GCD;
            Console.WriteLine("Least Common multiple:: " + lcm);
            Console.ReadKey();
        }
    }
}
