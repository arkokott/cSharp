using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1
{
    struct Rectangle
    {
        private int m_width;
        
        public int Width
        {
            get
            {
                return m_width;
            }
            set
            {
                m_width = value;
            }
        }

        private int m_height;

        public int Height
        {
            get
            {
                return m_height;
            }
            set
            {
                m_height = value;
            }
        }
    }

    class StructExample
    {
        static void Main()
        {
            //instantiate a new Rectangle struct
            //where Width is set to 1 and Height is set to 3

            Rectangle rect1 = new Rectangle();
            rect1.Width = 1;
            rect1.Height = 3;

            /*
            //you can also use object initialization syntax
            Rectangle rect11 = new Rectangle
            {
                Width = 1,
                Height = 3
            };
            */

            //show the value of Width and Height for rect1
            Console.WriteLine("rect1: {0}:{1}", rect1.Width, rect1.Height);
            //Console.WriteLine("rect11: {0}:{1}", rect11.Width, rect11.Height);

            Console.ReadKey();
        }
    }
}
