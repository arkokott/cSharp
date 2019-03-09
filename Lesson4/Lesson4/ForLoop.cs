using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class ForLoop
    {
        public static void ForLoops()
        {
            for (int i=0; i < 20; i++)
            {
                if (i == 10)
                    break;

                if (i % 2 == 0)
                    continue;

                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
