using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csTut = csharp_station.tutorial.myExample; //alias

class AliasDirective
{
    public static void Main()
    {
        //Call namespace member
        csTut.myPrint();
        myPrint();
    }

    static void myPrint()
    {
        Console.WriteLine("Not a member of csharp_station.tutorial.myExample.");
    }
}

namespace csharp_station.tutorial
{
    class myExample
    {
        public static void myPrint()
        {
            Console.WriteLine("This is a member of csharp_station.tutorial.myExample.");
        }
    }
}