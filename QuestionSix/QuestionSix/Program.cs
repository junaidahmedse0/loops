using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K;
            Console.WriteLine("Enter N for N!");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K for K!");
            K = int.Parse(Console.ReadLine());
            int kFact=1, NFact=1;
            if (1 < K && K< N)
            {
                while (K > 0)
                {

                    kFact = kFact * K;
                    K--;


                }


                while (N > 0)
                {

                    NFact = NFact * N;
                    N--;


                }
                Console.WriteLine("Nfact" + NFact);
                Console.WriteLine("Kfact" + kFact);
                double result = NFact / kFact;


                Console.WriteLine("Result is" + result);


            



            }
            Console.ReadKey();

        }
    }
}
