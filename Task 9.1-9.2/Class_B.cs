using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._1_9._2
{
    public class Class_B : ICustomComparable<Class_B>
    {
        public Class_B()
        {
            var rand = new Random();
            op1 = Convert.ToString(rand.Next(0, 100));
            op2 = rand.Next(0, 100);
        }

        public string op1 { get; set; }
        public double op2 { get; set; }

        public int CustomCompare(Class_B value)
        {
            return Convert.ToInt32(op1) + Convert.ToInt32(op2);
        }
    }
}
