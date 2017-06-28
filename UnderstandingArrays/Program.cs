using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            

            Console.WriteLine(numbers[1]); // display location 2 of the array
            Console.WriteLine(numbers.Length); //Length of array

            Console.ReadLine();
            */

            int[] numbers = new int[] { 5, 10, 15, 25, 26, 69, 90 };

            string[] names = new string[] { "Owain", "Mandy", "Frank", "Denis", "Marion" };

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "You can get what you want out of life" + 
                " if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray(); //take array and split it in to individual characters
            Array.Reverse(charArray); // reverse the order of the array

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
