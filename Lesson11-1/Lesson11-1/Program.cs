using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_1
{
    class IntIndexer
    {
        private string[] myData;

        public IntIndexer(int size)
        {
            myData = new string[size];

            for (int i=0; i < size; i++)
            {
                myData[i] = "empty";
            }
        }

        public string this[int pos]
        {
            get
            {
                return myData[pos];
            }
            set
            {
                myData[pos] = value;
            }
        }
        static void Main(string[] args)
        {
            int size = 10;

            IntIndexer myInd = new IntIndexer(size);

            myInd[9] = "Some Value";
            myInd[3] = "Another Value";
            myInd[5] = "Any Value";

            Console.WriteLine("\nIndexer Output\n");

            for (int i=0; i < size; i++)
            {
                Console.WriteLine("myInd[{0}]: {1}", i, myInd[i]);
            }

            Console.ReadKey();
        }
    }
}
