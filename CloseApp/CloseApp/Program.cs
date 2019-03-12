using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseApp
{
    class Program
    {
        static void Main()
        {

            String answer;
            bool a = true;


            do
            {
                Console.WriteLine("Close application? ");
                answer = Console.ReadLine();

                switch (answer.ToLower())
                {
                    case "t":
                        Console.WriteLine("Close.");
                        a = false;
                        break;
                    case "n":
                        Console.WriteLine("No close.");
                        a = true;
                        break;
                    default:
                        Console.WriteLine("No close deafult.");
                        a = true;
                        break;
                }
            } while (a == true);
        }
    }
}
