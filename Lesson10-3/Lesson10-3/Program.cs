using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_3
{
    public class Customer
    {
        private int m_id = -1;
        private string m_name = string.Empty;

        public Customer(int id, string name)
        {
            m_id = id;
            m_name = name;
        }

        public int ID
        {
            get
            {
                return m_id;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }
    }
    public class ReadOnlyCustomerManager
    { 
        public static void Main()
        {
            Customer cust = new Customer(1, "Amelio Rosales");

            Console.WriteLine(
                "ID: {0}, Name: {1}",
                cust.ID,
                cust.Name);

            Console.ReadKey();
        }
    }
}
