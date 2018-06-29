using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = 0;
            int decimalNum = 0;
            Console.WriteLine("Enter Hexa decimal Num");
            string hexNumber=Console.ReadLine();
            hexNumber = hexNumber.ToUpper();
            int lenght = hexNumber.Length;
            string hexCode = "0123456789ABCDEF";
            for (int index = 0; index < lenght; index++)
            {

                char digit = hexNumber[lenght-index-1];
                decimalNum = decimalNum + hexCode.IndexOf(digit) * (int)Math.Pow(16, power++);

            }

            Console.WriteLine("decimal Number" + decimalNum);
            Console.ReadKey();


        }
    }
}
