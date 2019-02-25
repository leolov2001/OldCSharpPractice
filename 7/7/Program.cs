using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n1 = Int32.Parse(Console.ReadLine());
            int n2 = factsum(n1);
            if (n1 == n2)
            {
                Console.WriteLine("The number is a strong number.");
            }
            else
                Console.WriteLine("The number is not a strong number.");

        }
        static int factsum(int a)
        {
            int temp = 0;
            while (a > 0)
            {
                int temp2 = a % 10;
                temp = temp + fact(temp2);
                a /= 10;
            }
            return temp;
        }
        static int fact(int a)
        {
            int temp = 1;
            for (int i = a; i > 0; i--)
            {
                temp = temp * i;
            }
            return temp;
        }
        
    }
}
