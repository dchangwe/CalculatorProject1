using System;
using BasicOperations;

namespace Multiplication
{
    
        public interface IMultiply
        {
            public dynamic Multiply(dynamic a, dynamic b);
        }
        public class Multiplying : IMultiply
        {
            public dynamic result;
            public dynamic Multiply(dynamic a, dynamic b)
            {

                result = (a, b);
                return result;
            }
        }
    }

        

