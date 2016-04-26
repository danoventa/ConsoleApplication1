using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animauls
{
    class Doge : Animul
    {
        public string name;
        public string owner;

        public override void move()
        {
            Console.WriteLine("Wobbling");
        }
    }
}
