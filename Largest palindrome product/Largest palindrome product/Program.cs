using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i=999;i>900;i--)
                for (j = i - 1; j > 900; j--)
                {
                    if (paLin(i * j) > 0)
                    {
                        Console.WriteLine("Biggest is a {0}", i*j);
                        Console.ReadLine();
                        return;
                    }
                }
            //i = paLin(9009);
            Console.WriteLine("Nothing found!!");
            Console.ReadLine();

        }
        static public int paLin(int i)
        {
            int j,l;
            j=i;
            l = 0;
            while (j  > 0)
            {
                l =l*10+ (j % 10) ;
                j = j / 10;
            }
            Console.WriteLine("Reverse is {0}", l);
            if (l == i)
                return i;
            else return 0;
        }
    }
}
