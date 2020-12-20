using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,temp,rev=0,temp2;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            temp2 = num;
            while(num>0)
            {
                temp = num % 10;
                rev = (rev * 10) + temp;
                num = num / 10;
            }
            if(rev==temp2)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
