using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class B: A
    {
        private int b = 2;
        public void Show_b()
        {
            Console.WriteLine($"\n The value of a is {a}\n");
            Console.WriteLine($"\n The value of b is {b}\n");
        }
    }
}
