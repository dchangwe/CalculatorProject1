using System;
using BasicOperations;


namespace SquareRoot
{
   public interface ISquareRoot
   {
       public dynamic SquareRoot(dynamic a);
   }
   public class SqRoot : ISquareRoot
   {
      public dynamic result;
      public dynamic SquareRoot(dynamic a)
      {
          result = Sqrt.SquareRoot(a);
          return result;
      }
    }
}