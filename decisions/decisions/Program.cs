using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Owain's Big Giveaway");
              Console.Write("Choose a door: 1,2, or 3: ");
              string userValue = Console.ReadLine();

              string message = "";

              if(userValue =="1")
                  message = "You won a new car!";
              else if(userValue == "2")
                 message = "You won a new boat";
             else if(userValue == "3")            
                  message = "You won a new dog";
              else
              { 
                  message = "Sorry, we didn't understand. ";
                  message += "You Lose.";
              }


              Console.WriteLine(message);
              Console.ReadLine(); */

            Console.WriteLine("Owain's Big Giveaway");
            Console.Write("Choose a door: 1,2, or 3: ");
            string userValue = Console.ReadLine();

            //If uservalue equals 1, display boat, else show length of rope.
            string message = (userValue == "1") ? "boat" : "length of rope";

            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}
