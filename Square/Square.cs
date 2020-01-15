using System;
using BasicOperations;

namespace Square
{
    public interface ISquare
        {
            public dynamic Square(dynamic a);
        }
        public class Squared : ISquare
        {
            public dynamic result;
            public dynamic Square(dynamic a)
            {
                result = Squares.Squared(a);
                return result;
            }

        }
    }
