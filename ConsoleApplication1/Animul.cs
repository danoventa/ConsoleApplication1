﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animauls
{
    class Animul
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age not less dan 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public virtual void move()
        {
            Console.WriteLine("Move");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("Mooooo");
        }
    }
}
