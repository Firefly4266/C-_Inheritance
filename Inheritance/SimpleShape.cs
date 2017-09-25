using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SimpleShape
    {
        double pri_width;
        double pri_height;

        public SimpleShape()
        {
            width = 0;
            height = 0;
        }
        public SimpleShape(double num)
        {
            width = num;
            height = num;
        }
        public double width
        {
            get
            {
                return pri_width;
            }
            set
            {
                pri_width = value;
            }
        }
        public double height
        {
            get
            {
                return pri_height;                
            }
            set
            {
                pri_height = value;
            }
        }

        public void ShowDim()
        {
            Console.WriteLine($" Width: {width}, Height: {height}.\n");
        }
    }
}
