using System;
using BasicOperations;

namespace Square
{
    public interface ISquare
        {
            public dynamic Square(dynamic a);
        }
        public class SqauredNumber : ISquare
        {
            public dynamic result;
            public dynamic Square(dynamic a)
            {
            result = Squared.Square(a);
                return result;
            }

        }
    }
