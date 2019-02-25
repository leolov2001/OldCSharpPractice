using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0; int neg = 0; int ze = 0;
            Console.WriteLine("Enter 10 elements");
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] == 0)
                {
                    ze++;
                }
                else if (a[i] > 0)
                    pos++;
                else
                    neg++;
            }
            Console.WriteLine("Zeros:{0},Positive:{1},Negative:{2}", ze, pos, neg);
            Console.ReadLine();
        }
    }
}
