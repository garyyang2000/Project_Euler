using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 7;
            int i = 14;
            while (counter < 10002)
            {
                if (judge_prime(i) != 0) 
                { 
                    Console.WriteLine("The {0} prime found {1}",counter, i); counter++; 
                }
                i++;
            }

            Console.WriteLine("The 10001st prime is {0}", i);
            Console.ReadLine();
        }
        static public long judge_prime(long i)
        {

            for (long j = 2; j * j <= i; j++)
            {
                if (i % j == 0) return 0;
            }
            return i;
        }
    }
}
