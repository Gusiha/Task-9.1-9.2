using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._1_9._2
{
    public class Class_A : ICustomComparable<Class_A>
    {
        public int op1 { get; set; }
        public int op2 { get; set; }

        public Class_A()
        {
            var rand = new Random();
            op1 = rand.Next(0, 100);
            op2 = rand.Next(0, 100);
        }

        public int CustomCompare(Class_A value)
        {
            return op1 + op2;
        }
    }
}
