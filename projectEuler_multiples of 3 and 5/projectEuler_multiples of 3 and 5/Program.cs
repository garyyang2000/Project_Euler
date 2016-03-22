using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler_multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            for (int i = 1; i <=333; i++)
            {
                sum += i * 3;
                
            }
            for (int i = 1; i < 200; i++)
            {
                if (i % 3 != 0)
                {
                    sum += i * 5;
                }
               
            }
            Console.WriteLine("the sum is {0}",sum);
            Console.ReadLine();
        }
    }
}
