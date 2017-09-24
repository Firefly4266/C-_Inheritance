using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Problem33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Greetings user, welcome to our program.");
            var newA = new A();
            newA.Show_a();
            var newB = new B();
            newB.Show_b();
        }
    }
}
