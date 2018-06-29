using System;
class ExampleThree
{
   static void Main(string[] args)
   {
   
     int factorial=1;
     Console.WriteLine("Enter num for factorial");
     int num=int.Parse(Console.ReadLine());
     while(true)
     {

         if(num<=1)
          {
              break;
          }
         factorial=factorial*num;
         num--;

     }
     Console.WriteLine("Factorial:: "+factorial);


   }





}