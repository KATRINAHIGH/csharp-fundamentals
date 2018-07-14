using System;
namespace Csharp.Fundamentals
{
    public class PredicateUtilities
    {
        public bool IsGreaterThan(int x, int y)
        {
            return x > y;
        }

        public bool IsLessThan(int x, int y)
        {
            return x < y;
        }

        public Boolean IsGreaterThanOrEqualTo(int x, int y)
        {
            return x >= y;
        }

      
        public Boolean IsLessThanOrEqualTo(int x, int y)
        {
            return x <= y;
        }
    }
}
