using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FluentDate
{
    public static class DateTimeExtensions
    {        
        public static IDatePositioner IsMoreThan(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.GreaterThan);
        }
        public static IDatePositioner IsLessThan(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.LessThan);
        }
        public static IDatePositioner Is(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.Equal);
        }
        public static IDatePositioner IsAtMost(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.LessThanOrEqual);
        }
        public static IDatePositioner IsAtLeast(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.GreaterThanOrEqual);
        }

    }
}
