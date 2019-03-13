using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5e2
{
    class Address
    {
    public string name;
    public string address;
    }

    class MethodParams
    {
        public static void Main()
        {
            string myChoice;

            MethodParams mp = new MethodParams();

            do
            {
                //show menu and get input from user
                myChoice = mp.getChoice();

                //Make a decision based on the user's choice
                mp.makeDecision(myChoice);

                //Pause to allow the user to see the results
                Console.Write("press Enter key to continue...");
                Console.ReadLine();
                Console.WriteLine();
            } while (myChoice != "Q" && myChoice != "q"); //Keep going until the user wants to quit
        }

        //show menu and get user's choice
        string getChoice()
        {
            string myChoice;

            // Print a menu
            Console.WriteLine("My Address Book\n");

            Console.WriteLine("A - Add New Address");
            Console.WriteLine("D - Delete Address");
            Console.WriteLine("M - Modify Address");
            Console.WriteLine("V - View Addresses");
            Console.WriteLine("Q - Quit\n");

            Console.WriteLine("Choice (A,D,M,V,or Q): ");

            //Retrive the user's choice
            myChoice = Console.ReadLine();

            return myChoice;
        }

        //make decision
        void makeDecision(string myChoice)
        {
            Address addr = new Address();

            switch (myChoice.ToLower())
            {
                case "a":
                    addr.name = "Joe";
                    addr.address = "C# Station";
                    this.addAddress(ref addr);
                    break;
                case "d":
                    addr.name = "Robert";
                    this.deleteAddress(addr.name);
                    break;
                case "m":
                    addr.name = "Matt";
                    this.modifyAddress(out addr);
                    Console.WriteLine("Name is now {0}.", addr.name);
                    break;
                case "v":
                    this.viewAddresses("Cheryl", "Joe", "Matt", "Robert");
                    break;
                case "q":
                    Console.Write("Bye.");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", myChoice);
                    break;
            }
        }

        //insert an address
        void addAddress(ref Address addr)
        {
            Console.WriteLine("Name: {0}, Address: {1} added.", addr.name, addr.address);
        }

        //remove an address
        void deleteAddress(string name)
        {
            Console.WriteLine("You wish to delete {0}'s address.", name);
        }

        //change an address
        void modifyAddress(out Address addr)
        {
            //Console.WriteLine("Name: {0}.", addr.name); // causes error!

            addr = new Address();
            addr.name = "Joe";
            addr.address = "C# Station";
        }

        //show addresses
        void viewAddresses(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("Name: {0}", name);
            }
        }
    }
}
