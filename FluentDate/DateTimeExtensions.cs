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
        /// <summary>
        /// Does a "GreaterThan" comparison of this date to the calculated date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfUnits">The number of units to include in the expression</param>
        /// <returns>IDatePositioner</returns>
        public static IDatePositioner IsMoreThan(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.GreaterThan);
        }
        /// <summary>
        /// Does a "LessThan" comparison of this date to the calculated date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfUnits">The number of units to include in the expression</param>
        /// <returns>IDatePositioner</returns>
        public static IDatePositioner IsLessThan(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.LessThan);
        }
        /// <summary>
        /// Does a "Equals" comparison of this date to the calculated date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfUnits">The number of units to include in the expression</param>
        /// <returns>IDatePositioner</returns>
        public static IDatePositioner Is(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.Equal);
        }
        /// <summary>
        /// Does a "LessThanOrEqual" comparison of this date to the calculated date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfUnits">The number of units to include in the expression</param>
        /// <returns>IDatePositioner</returns>
        public static IDatePositioner IsAtMost(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.LessThanOrEqual);
        }
        /// <summary>
        /// Does a "GreaterThanOrEqual" comparison of this date to the calculated date.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfUnits">The number of units to include in the expression</param>
        /// <returns>IDatePositioner</returns>
        public static IDatePositioner IsAtLeast(this DateTime dateTime, int numberOfUnits)
        {
            return new FluenDateBuilder(dateTime, numberOfUnits, ExpressionType.GreaterThanOrEqual);
        }

    }
}
