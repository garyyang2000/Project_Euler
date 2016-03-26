using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amicable_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum1;
            int sum2;
            int sum3=0;
            for (int i = 10; i <= 10000; i++)
            {
                sum1 = numberOfDiv(i);
                sum2 = numberOfDiv(sum1);
                if ((i == sum2)&&(i!=sum1))
                {
                    textBox1.Text += "Amicable numbers found:" + i.ToString() +" and "+ sum1.ToString()+"\r\n";
                    sum3 += i;
                }

            }
            textBox1.Text += "\r\nSum is" + sum3.ToString();
        }
        public int numberOfDiv(int input)
        {
            int n = input;
            int flag = 0;
            int[] factors = new int[300];
            int j = 0;
            //int last = 0;
            int tmp = 0;
            int sum = 1;
            //Following part finds out all the prime factors of n;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    factors[j] = i;
                    flag++;
                    n = n / i;
                    i--;
                    j++;
                }
            }
            flag = factors[0];
            int time = 1;
            tmp = 1;
            // Console.Write("==>");
            // sum of n's divisors:f(n)=(p1^0+p1^1+p1^2+…p1^a1)(p2^0+p2^1+p2^2+…p2^a2)…(pk^0+pk^1+pk^2+…pk^ak）
            //num of n's divisors:f(n)=(a₁+1)(a₂+1)(a₃+1)…(ak+1)
            for (int i = 1; i <= j; i++)
            {

                if (flag == factors[i])
                {
                    time++;
                }
                else
                {
                    tmp = 0;
                    for (int k = 0; k <= time; k++)
                    {
                        tmp += (int)Math.Pow(flag, k);
                    }
                    sum *= tmp;
                    time = 1;
                    tmp = 1;
                    flag = factors[i];
                }
            }
            return sum - input;
        }
    }
}
