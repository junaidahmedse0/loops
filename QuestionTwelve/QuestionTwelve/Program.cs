using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] arr = new int[10];
            Console.WriteLine("Enter number");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                arr[i] = n % 2;
                n = n / 2;


            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("" + arr[j]);

            }
            Console.ReadKey();


        }
    }
}
