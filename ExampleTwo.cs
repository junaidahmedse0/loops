using System;
class ExampleTwo
{
  static void Main(string[] args)
  {

   Console.WriteLine("Enter number until you want to sum");
   int n=int.Parse(Console.ReadLine());
   int sum=0;
   int num=0;
   while(num<n)
   {

    sum+=num;
    Console.Write("+"+num);
    num++;

   }
   Console.Write("="+sum);    


  }



}