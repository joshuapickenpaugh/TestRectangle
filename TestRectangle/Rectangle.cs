//JP, IN2017, 10062015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRectangle
{
    //2f:
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {

        }

        public Rectangle(int l, int w)
        {
            Length = l;
            width = w;
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = 0;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = 0;
            }
        }

        //2g:
        public void RectangleArea(int L, int W)
        {
            int area = 0;
            area = L * W;
            Console.WriteLine("FROM THE RECTANGLE CLASS: The area is {0}.", area);
        }


    }
}
