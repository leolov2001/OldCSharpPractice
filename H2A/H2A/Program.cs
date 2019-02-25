using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Array:");
            int l = Int32.Parse(Console.ReadLine());
            H2A(l);
        }

        static void H2A(int l)
        {
            int[] a = new int[l];
            for (int i = 0; i <= l-1; i++)
            {
                Console.Write("Enter a number:");
                a[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 1; i++)
            {
                for (int j = i + 1; j <= l-1; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("The First largest number is {0} and the second largest number is {1}.", a[0], a[1]);
        }
    }
}
