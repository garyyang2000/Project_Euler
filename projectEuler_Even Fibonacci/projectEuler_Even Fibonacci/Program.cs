using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler_Even_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long  max=4000000;
            long  sum=0;
            long a1=1;
            long a2=2;
            long a3=0;
            sum=a2;
            while (a3<max)
            {
                a3 = a1 + a2;
                a1 = a2;
                a2 = a3;
                //Console.WriteLine("a3 is {0} ", a3);
                if ((a3%2==0)&&(a3<max))
                    sum += a3;
                //Console.WriteLine("sum is {0}", sum);
            }
            Console.WriteLine("The final sum is {0}", sum);

            max = 600851475143;
            a1=0;
            for (long i = 7; i*i < max; i++)
            {
                if (max % i == 0) { a1 = judge_prime(i); Console.WriteLine("i is {0} ", i); }
                if (a1 != 0) a2 = a1;
            }
            Console.WriteLine("The final factor is {0}", a2);
            Console.ReadLine();
        }

        static public long judge_prime(long i)
        {
            
            for (long j = 2; j*j < i; j++)
            {
                if (i % j == 0) return 0; 
            }
            return i;
        }
    }
}
