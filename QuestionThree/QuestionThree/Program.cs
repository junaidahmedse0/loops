using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter size of array");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());



            }
            int largest, smallest;
            largest = arr[0];
            smallest = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {

                if (largest < arr[j])
                {
                    largest = arr[j];

                }
                else
                    continue;

            }
            for (int k = 0; k < arr.Length; k++)
            {
                if (smallest > arr[k])
                {

                    smallest = arr[k];

                }

            }

            Console.WriteLine("smallest is" + smallest + "largest:: " + largest);
            Console.ReadKey();
        }
    }
}
