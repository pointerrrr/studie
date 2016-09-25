using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentnr = Console.ReadLine();
            int nr;
            int[] nM = new int[7];
            bool number = Int32.TryParse(studentnr, out nr);
            if (number && (nr >= 1000000 && nr < 10000000))
            {
                nr = 0;
                for (int x = 0; x <= 6; x++)
                {
                    nM[x] = studentnr[x] - 48;
                    //Console.WriteLine(nM[x]);
                    nr = nr + (nM[x] * (7 - x));
                    //Console.WriteLine(nr);
                }
                if (nr % 11 == 0)
                { Console.WriteLine("Your number is valid."); }
                else
                { Console.WriteLine("Your number is invalid"); }
            }
            else
            {
                Console.WriteLine("Please enter a 7 digit number!");
            }
            Console.ReadKey();

        }
    }
}
