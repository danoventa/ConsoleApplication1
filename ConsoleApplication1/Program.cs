using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animauls;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Essential Training











            // Up and Running with C#
            Stack myStack = new Stack();
            myStack.Push("String");
            myStack.Push(34);
            myStack.Push(myStack);
            myStack.Pop();

            SortedList<string, string> sortedListD = new SortedList<string, string>();

            sortedListD.Add("Dan", "IsGreat");
            sortedListD.Add("He", "IsGreatest");
            sortedListD.Add("I", "IsGreatester");

            Console.WriteLine(sortedListD);

            Stack<string> strStack = new Stack<string>();
            strStack.Push("A String");

            int intValue = 32;
            object objValue = intValue;
            string strValue;

            string errorMessage;

            try
            {
                strValue = (string)objValue;
            }
            catch(InvalidCastException dErp)
            {
                errorMessage = dErp.Message;
                Console.WriteLine(errorMessage);
            }


            Carro VW = new Carro();
            VW.Drive();
            VW.Stopping();

            Animul newAnimul = new Animul();
            newAnimul.move();

            Animul Dog = new Animul();
            Dog.Age = 3;
            Dog.Color = "Blue";
            Console.WriteLine(Dog.Age);
            Console.WriteLine(Dog.Color);
            Sum(1, 2);

            Doge Nixon = new Doge();
            Nixon.move();

            Nixon.move();
            Nixon.makeNoise();


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
