using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; 

namespace QuestionEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, temporary;
            BigInteger factorial = 1;
            int numberOfZeros = 0;
            Console.WriteLine("Enter Number:  ");
            N = int.Parse(Console.ReadLine());
            int temp = N;
            while (N > 0)
            {

                factorial = factorial * N;
                N--;
                
            }
            Console.WriteLine("Factorial " + factorial);


            if (temp>= 5)
            {
                do
                {

                    temporary = temp / 5;
                    if (temporary != 0)
                    {

                        numberOfZeros = numberOfZeros + temporary;
                        temp= temporary;

                    }
                    else
                    {
                        break;
                   }

                } while (true);
                
            }
            Console.WriteLine("Number Of Zeros" + numberOfZeros);
            Console.ReadKey();
        }
    }
}
