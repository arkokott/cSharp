using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main()
        {
            int myInt = 0;

            while (myInt < 10)
            {
                Console.Write("{0} ", myInt);
                myInt++;
            }

            Console.WriteLine();

            //DoLoop.DoLoops();
            //ForLoop.ForLoops();
            ForEachLoop.ForEachLoops();

            Console.ReadLine();
        }
    }
}
