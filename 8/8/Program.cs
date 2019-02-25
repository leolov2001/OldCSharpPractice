using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = Int32.Parse(Console.ReadLine());
            int a = 0; int b = 0;

            factors(num, ref a, ref b);
            Console.WriteLine("The Highest Factor of {0} is {1}. And the Lowest Factor is {2}.", num, a, b);

        }

        static void factors(int num, ref int a, ref int b)
        {
            int n1, n2;
            for (n1 = num - 1; n1 >= 0; n1--)
            {
                if (num % n1 == 0)
                {
                    break;
                }
            }
            for (n2 = 2; n2 <= num-1; n2++)
            {
                if (num % n2 == 0)
                {
                    break;
                }
            }
            a = n1;
            b = n2;
        }
    }
}
