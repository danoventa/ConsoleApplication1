using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Carro
    {
        public string make;
        public string model;
        public string color;

        public void Drive()
        {
            Console.WriteLine("Drivving");
        }

        public void Stopping()
        {
            Console.WriteLine("Stopppping");
        }
    }
}
