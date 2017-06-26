using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name:");
            string myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name:");
            myLastName = Console.ReadLine();

            Console.WriteLine("Helo, " + myFirstName + " " + myLastName);
        }
    }
}
