using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int grondtal, exponent;
            grondtal = Int32.Parse(Console.ReadLine());
            exponent = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Driewerf(grondtal, exponent));
            Console.ReadLine();
        }

        public static int Driewerf(int x, int n) {
            int result = 1;
            int counter = 0;
            while (counter < n)
            {
                counter++;
                result = result * x;
            }

            return result;
        }
    }
}
