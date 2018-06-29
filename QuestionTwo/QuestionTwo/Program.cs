using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Enter number:: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                if (i % 3 == 0 && i % 7 == 0)
                {


                    continue;
                }
                else
                {

                    Console.WriteLine("  " + i);
                }
            }
            Console.ReadKey();

        }
    }
}
