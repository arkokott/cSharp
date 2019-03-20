using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_3
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

        public Rectangle (int width, int height)
        {
            m_width = width;
            m_height = height;
        }
    }
    class StructExample
    {
        static void Main()
        {
            //instantiate a new Rectangle struct
            //where Width is set to 5 and Height is set to 7
            Rectangle rect2 = new Rectangle(5, 7);

            //show the value of Width and Height for rect2
            Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

            Console.ReadKey();
        }
    }
}
