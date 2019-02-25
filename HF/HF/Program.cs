using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = Int32.Parse(Console.ReadLine());

            int high = HF(num);
            Console.WriteLine("The Highest Factor of {0} is {1}.", num, high);
        }
        static int HF(int a)
        {
            int n1;
            for ( n1 = a-1; n1 > 0; n1--)
            {
                if (a % n1 == 0)
                {
                    break;
                }
            }
            return n1;
        }
    }
}
