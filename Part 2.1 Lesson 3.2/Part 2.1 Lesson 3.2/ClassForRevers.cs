using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_3._2
{
   public  class ClassForRevers
    {
        public void Revers(string str)
        {
            char[] vars = str.ToCharArray();
            Array.Reverse(vars);
            Console.WriteLine();
            string outp = new string(vars);
            Console.WriteLine(outp);
        }
    }
}
