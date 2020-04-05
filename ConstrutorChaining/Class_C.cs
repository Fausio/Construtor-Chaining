using System;
using System.Collections.Generic;
using System.Text;

namespace ConstrutorChaining
{
    class Class_C : Class_B
    {
        public Class_C()
            : base(1)
        {
            Console.WriteLine("Defaoult construtor of class C");
        }
         
    }
}
