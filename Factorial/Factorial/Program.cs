using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, Fac;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Fac = num;
            while(num>1)
            {
                Fac = Fac * (num - 1);
                --num;
            }
            Console.WriteLine(Fac);
            Console.ReadLine();
        }
    }
}
