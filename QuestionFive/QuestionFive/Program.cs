using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num for Fabnocii series");
            int num = int.Parse(Console.ReadLine());
            int temp1=0, temp2=0,fab=0;
            for (int i = 0;  i < num; i++)
            {
                if (i == 0)
                {

                    temp1 = i;
                    Console.WriteLine("  " + temp1);


                }
                else if (i == 1)
                {

                    temp2 = i;
                    Console.WriteLine("  " + temp2);


                }
                else
                {
                    fab = temp1 + temp2;
                    temp1 = temp2;
                    temp2 = fab;


                    Console.WriteLine("  " + fab);
                }





            }
            Console.ReadKey();
        }
    }
}
