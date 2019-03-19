using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_5
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class AutoImplementedCustomerManager
    { 
        static void Main()
        {
            Customer cust = new Customer();

            cust.ID = 1;
            cust.Name = "Amelio Rosales";

            Console.WriteLine("ID: {0}, Name: {1}", cust.ID, cust.Name);

            Console.ReadKey();
        }
    }
}
