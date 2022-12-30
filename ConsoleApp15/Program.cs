using System;

namespace primenumber
{
    internal class programe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the frist number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int n2 = int.Parse(Console.ReadLine());

            //read the number

            Console.Write("the prime number is:");

            for(int p =n1; p<n2 ;p++)
            {
                int num=0;
                for (num = 2; num < p; num++)
                {
                    if (p % num ==0)
                                      break;
                }
                    if (num == p)
                   
                        Console.Write( + p+",");
            }
        }
    }
}