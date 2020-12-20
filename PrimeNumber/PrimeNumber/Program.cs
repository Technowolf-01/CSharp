using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i , m = 0, flag = 0 ;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            m = num / 2;
            for(i=2;i<=m;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Not a prime number");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
            {
                Console.WriteLine("Prime Number");
            }
            Console.Read();

        }


    }
}
