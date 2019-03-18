using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class OutputClass
    {
        string myString;

        //Constructor
        public OutputClass (string inputString)
        {
            myString = inputString;
        }

        //Instance method
        public void printString()
        {
            Console.WriteLine("{0}", myString);
        }

        //Destructor
        ~OutputClass()
        {
            //Some resource cleanup routines
        }

        class ExampleClass
        {
            public static void Main()
            {
                //Instance of OutputClass
                OutputClass outCl = new OutputClass("This is printed by the output class.");

                //Call Output class method
                outCl.printString();
            }
        }
    }
}
