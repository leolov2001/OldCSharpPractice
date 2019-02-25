using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int n2 = Int32.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                HCF(n1, n2);
            }
            else
                HCF(n2, n1);
        }
        static void HCF(int n1, int n2)
        {
            int temp;
            for (temp = n1 - 1; temp > 0; temp--)
            {
                if (n1 % temp == 0)
                {
                    if (n2%temp == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("The Highest Common Factor is {0}.", temp);
        }
    }
}
