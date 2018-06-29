using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine  ("Enter number:: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                Console.WriteLine("  " + i);

            }
            Console.ReadKey();


        }
    }
}
