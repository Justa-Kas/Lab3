using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there. Please enter your name.");
            string name = Console.ReadLine();
            bool keepGoing = true;
            while (keepGoing == true)
            {
                Console.WriteLine("Hi "+name+", please enter an integer between 1 and 100");
                int numberGiven = int.Parse(Console.ReadLine());
                //verifying is the number between 1 and 100
                if (!(numberGiven >= 1 && numberGiven <= 100))
                {
                    Console.WriteLine("Please try again "+name+", number was not in the acceptable range.");
                    continue;
                }
                else
                {
                    //displaying a message depending on the number given
                    if (numberGiven % 2 == 1)
                    {
                        Console.WriteLine(numberGiven + " is odd.");
                    }
                    else if (numberGiven >= 2 && numberGiven < 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (numberGiven >= 26 && numberGiven <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (numberGiven >60)
                    {
                        Console.WriteLine(numberGiven+" is even");
                    }

                }
                
                Console.WriteLine("Continue? Type n to quit or press any key to try again.");
                string repeatAnswer = Console.ReadLine();
                //ends the loop only if n is typed
                if (repeatAnswer.ToLower() == "n")
                {
                    keepGoing = false;
                    Console.WriteLine("Goodbye "+name+"! Press any key to quit.");
                    Console.ReadKey();

                }

            }
        }
    }
}
