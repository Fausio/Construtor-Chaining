using System;
using System.Collections.Generic;
using System.Text;

namespace ConstrutorChaining
{
    class Class_B : Class_A
    {
        public Class_B()
            : base(1)
        {
            Console.WriteLine("Defaoult construtor of class B");
        }

        public Class_B(int number)
        {
            Console.WriteLine("Defaoult construtor of class B with paramiter");
        }

        public Class_B(int numberOne,int numbertwo)
        {
            Console.WriteLine("Defaoult construtor of class B with 2 paramiters");
        }
    }
}
