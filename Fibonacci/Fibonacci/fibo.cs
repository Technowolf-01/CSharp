using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class fibo
    {
        public void calc()
        {
            int i,n, num1=0, num2=1, temp;
            Console.WriteLine("enter the input");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                
                Console.WriteLine(num1);
                temp = num1 + num2;
                num1 = num2;
                num2 = temp;
                
            }
            Console.ReadLine();
        }
    }
}
