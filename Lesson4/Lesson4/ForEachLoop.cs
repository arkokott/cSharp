using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class ForEachLoop
    {
        public static void ForEachLoops()
        {
            string[] names = {"Cheryl", "Joe", "Matt", "Robert"};

            foreach (string person in names)
            {
                Console.WriteLine("{0} ", person);
            }
        }

    }
}
