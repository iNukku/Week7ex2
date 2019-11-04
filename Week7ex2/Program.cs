using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7ex2
{
    /*
     Write a program with a baseclass and an inherited class. Both of them should have a method - void Display() - that prints a message (different messages for base class and inherited class). 
    Write a test program that calls the Display() method on the inherited class. 
    Explain what is being rendered and why. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            TheChild myChildClass = new TheChild();
            myChildClass.Display();
            Console.ReadKey();
        }
    }
}
