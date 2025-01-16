using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // print out the prompt to ask for the name
            Console.WriteLine("What is your name?");
            // delcare a string variable to hold the use input
            string name = Console.ReadLine();
            // print out the prompt to ask for the fav color
            Console.WriteLine("What is your favorite coler?");
            // declare a string varible to hold fav color
            string color = Console.ReadLine();
            //print out confirmed message
            Console.WriteLine("Hello " + name + " Your favorite color is " + color);
            //stop the screen for user to see result
            Console.ReadLine();
        }
    }
}
