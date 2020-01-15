using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations
{
    public class SquareRoot
    {
        public static int SqRoot(int a)
        {
            double b = Math.Sqrt(a);
            int c = Convert.ToInt32(b);
            return c;
        }
        public static double SqRoot(double d)
        {
            double e = Math.Sqrt(d);
            return e;
        }

        
    }
}


