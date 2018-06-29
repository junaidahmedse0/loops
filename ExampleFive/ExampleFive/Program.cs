using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int n=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter num2");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1;
            do {

                product = product * num;
                num++;
            }
            while (num<m);
            Console.WriteLine("product is:: " + product);

            Console.ReadKey();
        }
    }
}
