﻿using System;
using BasicOperations;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtract(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;
        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }
    }
}