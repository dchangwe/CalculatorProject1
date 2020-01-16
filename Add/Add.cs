using System;
using BasicOperations;

namespace Add
{
    
        public interface IAdd
        {
            public dynamic Sum(dynamic a, dynamic b);

        }
        public class Adding : IAdd
        {
            public dynamic result;
            public dynamic Sum(dynamic a, dynamic b)
            {
            result = Addition.Sum(a, b);
                return result;
            }
        }
    }


