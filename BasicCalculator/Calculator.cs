using System;
using BasicOperations;

using Add;
using Divide;

using Multiplication;

using Square;

using SquareRoot;
using Subtract;


namespace BasicCalculator
{
    
        public class Calculator : IAdd, IDivide, IMultiply, ISquare,  ISquareRoot, ISubtract

        {

            Adding add = new Adding();

            Dividing divide = new Dividing();

            Multiplying multiply = new Multiplying();

            SqauredNumber square = new SqauredNumber();

            SqRoot root = new SqRoot();
        Subtracting subtract = new Subtracting();
            

            public dynamic result;



            public dynamic Sum(dynamic a, dynamic b)

            {

                result = add.Sum(a, b);

                return result;

            }

            public dynamic Quotient(dynamic a, dynamic b)

            {

                result = divide.Quotient(a, b);

                return result;

            }

            public dynamic Subtract(dynamic a, dynamic b)

            {

                result = subtract.Subtract(a, b);

                return result;

            }

            public dynamic Multiply(dynamic a, dynamic b)

            {

                result = multiply.Multiply(a, b);

                return result;

            }

            public dynamic Square(dynamic a)

            {

            result = square.Square(a);

                return result;

            }



            

            public dynamic Root(dynamic a)

            {

                result = root.Root(a);

                return result;

            }
        }
    }


