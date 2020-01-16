using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations
{
    public class SquareRootNumber
    {
        public static int Root(int a)
        {
            double b = Math.Sqrt(a);
            int c = Convert.ToInt32(b);
            return c;
        }
        public static double Root(double d)
        {
            double e = Math.Sqrt(d);
            return e;
        }

        
    }
}


