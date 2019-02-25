using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches2Centimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value in Inches:");
            int inch = Int32.Parse(Console.ReadLine());

            double cms = inch2cm(inch);
            Console.WriteLine("{0} inches = {1} cms", inch, cms);
        }

        static double inch2cm(int a)
        {
            double cm;
            cm = a * 2.54;
            return cm;
        }
    }

}
