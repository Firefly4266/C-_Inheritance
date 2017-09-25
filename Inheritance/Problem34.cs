using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Problem34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Greetings user, welcome to our program.");
            SimpleShape shape = new SimpleShape(5);
            Console.Write("\n The default settings for the square are ");
            shape.ShowDim();
            Console.Write("\n User, please enter a new number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            SimpleShape newShape = new SimpleShape(num);
            Console.Write("\n The default settings for the new square are ");
            newShape.ShowDim();
        }
    }
}
