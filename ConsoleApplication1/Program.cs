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
            if (NrCheck(studentnr))
            { Console.WriteLine("Your number is valid!");}
            else
            { Console.WriteLine("Your number is invalid!"); }
            Console.ReadKey();

        }
        private static bool NrCheck(string studentnr)
        {
            int nr;
            int[] nM = new int[7];
            bool number = Int32.TryParse(studentnr, out nr);
            if (number && (studentnr.Length == 7))
            {
                nr = 0;
                for (int x = 0; x <= 6; x++)
                {
                    nM[x] = studentnr[x] - 48;
                    nr = nr + (nM[x] * (7 - x));
                }
                if (nr % 11 == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { 
                return false;
            }     
        }
    }    
}
