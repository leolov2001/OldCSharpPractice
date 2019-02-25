using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HN
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = "0";
            int high = 0;
            while(n1 != "x" && n1 != "X")
            {
                if (Int32.Parse(n1) > high)
                {
                    high = Int32.Parse(n1);
                }
                Console.WriteLine("Enter a number (x to cancel):");
                n1 = Console.ReadLine();
            }
            Console.WriteLine("The Highest number of all the values you have entered is: {0}", high);
        }
    }
}
