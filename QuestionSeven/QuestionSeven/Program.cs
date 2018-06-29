using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K;
            Console.WriteLine("Enter N:: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:: ");
            K = int.Parse(Console.ReadLine());
            int subValue = N - K;
            int kFact=1, nFact=1,subFact=1;
            if (1 < K && K < N)
            {
                while (N > 0)
                {

                    kFact = kFact * N;
                    N--;
                }
                while (K > 0)
                {
                    nFact = nFact * K;
                    K--;
                }
                while (subValue > 0)
                {
                    subFact = subFact * subValue;
                    subValue--;


                }
                Console.WriteLine("Facts ::" + ((nFact * kFact) / subFact));
            }
            Console.ReadKey();
        }
    }
}
