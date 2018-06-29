using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter N");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j < N + i; j++)
                {

                    Console.Write("  " + j);

                }


                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
