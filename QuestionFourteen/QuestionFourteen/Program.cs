using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFourteen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Decimal Number for hexadecimal Conversion");
            num = int.Parse(Console.ReadLine());
            int rem;
            string str2 = "";
            char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            while (num > 0)
            {
                rem = num % 16;
                str2 = hex[rem] + str2;
                num = num / 16;

            }

            Console.WriteLine("Decimal to HexaConversion" + str2);
            Console.ReadKey();
        }
    }
}
