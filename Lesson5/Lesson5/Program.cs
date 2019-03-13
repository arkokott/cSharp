using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class OneMethod
    {
        public static void Main()
        {
            string myChoice;

            OneMethod om = new OneMethod();

            do
            {
                myChoice = om.getChoice();

                // Make a decision based on the user's choice

                switch (myChoice.ToLower())
                {
                    case "a":
                        Console.WriteLine("You wish to add an address.");
                        break;
                    case "d":
                        Console.WriteLine("You wish to delete an address.");
                        break;
                    case "m":
                        Console.WriteLine("You wish to modify an address.");
                        break;
                    case "v":
                        Console.WriteLine("You wish to view the address list.");
                        break;
                    case "q":
                        Console.WriteLine("Bye.");
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid chocie", myChoice);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("press Enter key to continue...");

                Console.ReadLine();
                Console.WriteLine();

            } while (myChoice != "q"); //Keep going until the user wants to quit
        }

        string getChoice()
        {
            string myChoice;

            //Print a menu
            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add New Address");
            Console.WriteLine("D - Delete Address");
            Console.WriteLine("M - Modify Address");
            Console.WriteLine("V - View Addresses");
            Console.WriteLine("Q - Quit\n");

            Console.Write("Choice (A,D,M,V or Q): ");

            //Retrieve the user's choice
            myChoice = Console.ReadLine();
            Console.WriteLine();

            return myChoice;
        }
    }
}
