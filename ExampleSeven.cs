using System;
class ExampleSeven
{
  static void Main(string[] args)
  {
    Console.WriteLine("enter num");
    int num=int.Parse(Console.ReadLine());
    int sum=0;
    for(int i=1;i<=num;i+=2)
    {

     if(i%7==0)
      {
       continue;
       }
       sum=+i;

     }
       Console.WriteLine("Sum is:: "+sum);
       Console.ReadKey();

   }



}