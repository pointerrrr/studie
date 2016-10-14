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
            float x;
            x = float.Parse(Console.ReadLine());
            //d= Int32.Parse(Console.ReadLine());
            Console.WriteLine(wortel(x)); ; ; ; ; ; ; ; ;
            Console.ReadLine();
        }

        public static float wortel(float y) {
            float result = y;
            for (int x = 0; x < 100; x++) {
                result = (result + y / result) / 2;
            }
            return result;
            //return result;
        }
    }
}
