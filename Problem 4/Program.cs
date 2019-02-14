using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, i;
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; ++i)
            {
                for (j = 0; j <= i; ++j)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }

        }
    }
}

/* 
 n=3
 i=0; i<3 ==> j=0; 0<=0; ==> [*] ==> ++j = 1 --> 1<0 wrong , go to ith for loop again 


 */