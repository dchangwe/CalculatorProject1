using System;
using BasicOperations;


namespace SquareRoot
{
   public interface ISquareRoot
   {
       public dynamic Root(dynamic a);
   }
   public class SqRoot : ISquareRoot
   {
      public dynamic result;
      public dynamic Root(dynamic a)
      {
            result = SquareRootNumber.Root(a);
          return result;
      }
    }
}