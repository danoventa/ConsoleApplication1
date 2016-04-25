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
            Sum(1, 2);

            Console.WriteLine(Concatenate2("test ", "me"));
            Concatenate("Test, ", "again");

            for(int counter = 0; counter < 11; counter++)
            {
                Console.WriteLine(counter);
            }
        }

        static public void Sum(int one, int two)
        {
            Console.WriteLine(one + two);
        }

        static public void Concatenate(string first, string second)
        {
            string whole = first + second;
            Console.WriteLine(whole);
        }

        static string Concatenate2(string first, string second)
        {
            string whole = first + second;
            return whole;
        }
    }
}
