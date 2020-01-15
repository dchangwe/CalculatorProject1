using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations
{
    public class Subtraction
    {
        public static int Subtract(int f, int g)
        {
            return f - g;
        }
        public static double Subtract(double f, double g)
        {
            return f - g;
        }

        public static double Subtract(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA)
            {
                c = Subtract(a, c);
            }

            return c;
        }
        public static int Subtract(int[] arrayA)
        {
            int c = 0;
            foreach (int a in arrayA)
            {
                c = Subtract(a, c);
            }
            return c;
        }

    }
}
    

