using System;
class ExampleFour
{
   static void Main(string[] args)
   {
      Console.WriteLine("Enter Num");
      int num=int.Parse(Console.ReadLine());
      decimal factorial=1;

     do
     {
      factorial=factorial*num;
      num--;

     }while(num>0);

     Console.WriteLine("Factorial is:: "+factorial);

   }





}