using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDate
{
    public interface IDateQantifier
    {
        /// <summary>
        /// Makes sure the source date is before the target date.        
        /// </summary>
        /// <param name="dateTime">The target date</param>
        /// <returns>Returns true if the calculated date is before the target date.</returns>
        bool Before(DateTime dateTime);
        /// <summary>
        /// Makes sure the source date is after the target date.
        /// </summary>
        /// <param name="dateTime">The target date</param>
        /// <returns>Returns true if the calculated date is after the target date.</returns>
        bool After(DateTime dateTime);
        /// <summary>
        /// Makes sure the source date is before the target date.        
        /// </summary>
        /// <remarks> 
        /// Campares the source date to DateTime.Today for "Day" Calendar Units or larger. Uses
        /// DateTime.Now for Calendar Units less that "Day".
        /// </remarks>
        bool Ago {get;}
        /// <summary>
        /// Makes sure the source date is after the target date.
        /// </summary>
        /// <remarks>
        /// Compares the source date to the DateTime.Now
        /// </remarks>
        bool FromNow { get; }
        /// <summary>
        /// Makes sure the source date is after the target date.
        /// </summary>
        /// <remarks>
        /// Compares the source date to the DateTime.Today
        /// </remarks>
        bool FromToday { get; }
    }
}
