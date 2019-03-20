using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_5
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

        public Rectangle(int width, int height)
        {
            m_width = width;
            m_height = height;
        }

        public Rectangle Add(Rectangle rect)
        {
            //create instance of rectangle struct with default constructor
            Rectangle newRect = new Rectangle();

            //add matching axes and assign to new Rectangle struct
            newRect.Width = Width + rect.Width;
            newRect.Height = Height + rect.Height;

            //return new Rectangle struct
            return newRect;
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

            //show the value of Width and Height for rect1
            Console.WriteLine("rect1: {0}:{1}", rect1.Width, rect1.Height);

            //instantiate a new Rectangle struct
            //where Width is set to 5 and Height is set to 7
            Rectangle rect2 = new Rectangle(5, 7);

            //show the value of Width and Height for rect2
            Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

            //invoke the Add method on the rect1 Rectangle struct instatnce,
            //passing the rect2 Rectangle struct instance as an argument
            //and assigning teh new copy of the value returned by the
            //Add method to the rect2 Rectangle struct
            Rectangle rect3 = rect1.Add(rect2);

            //show the value of Width and Height for rect3
            Console.WriteLine("rect3: {0}:{1}", rect3.Width, rect3.Height);

            Console.ReadKey();
        }
    }
}
